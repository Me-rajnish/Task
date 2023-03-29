using Microsoft.AspNetCore.Mvc;
using Task2.Models;
using Task2.Repository;

namespace Task2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IDroneRepository _repository;

        public CustomerController(IDroneRepository droneRepository)
        {
            _repository = droneRepository;
        }

        //This method is used for display a list of customer
        [HttpGet]
        public ActionResult GetCustomer()
        {
            List<CustomerTb> customers = _repository.GetCustomers();
            return View(customers);
        }

        [HttpGet]
        public ActionResult CustomerAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerAdd(CustomerTb customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool IsAdd = _repository.CustomerAdd(customer);
                    if (IsAdd)
                    {
                        TempData["CustomerAdd"] = "Customer Added Successful";
                        return RedirectToAction("GetCustomer");
                    }
                    else
                    {
                        View();
                    }
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }

            return View();
        }


        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            CustomerTb customer= _repository.GetCustomerById(id);
            return View(customer);
        }


        [HttpPost]
        public ActionResult EditCustomer(CustomerTb customer)
        {
           bool IsUpdate= _repository.UpdateCustomer(customer);
            if (IsUpdate)
            {
                TempData["CustomerUpdate"] = "Customer Update Successful";
                return RedirectToAction("GetCustomer");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteCustomer(int id)
        {
            bool IsDelete = _repository.DeleteCustomer(id);
            if (IsDelete)
            {
                TempData["CustomerDelete"] = "Customer Delete Successful";

                return RedirectToAction("GetCustomer");
            }

            return RedirectToAction("GetCustomer");


        }

    }
}