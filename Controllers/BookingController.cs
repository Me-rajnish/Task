using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Task2.Models;
using Task2.Repository;

namespace Task2.Controllers
{
    public class BookingController : Controller
    {
      
        private readonly IBookingRepository _bookingRepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        [HttpGet]
        public ActionResult BookingAdd(int id)
        {
            CustomerTb customer = CustomerName(id);
            if (customer != null) { 
            ViewBag.FirstName = customer.FirstName;
            ViewBag.Email = customer.Email;
            ViewBag.LastName = customer.LastName;
                ViewBag.Id = customer.CustomerId;
        }
            ViewBag.GetDroneLocation = GetDroneLocation();
            ViewBag.Shot = GetShot();
            return View();
        }

        [HttpPost]
        public ActionResult BookingAdd(BookingCustomerTb booking)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    bool IsAdd = _bookingRepository.BookingAdd(booking);
                    if (IsAdd)
                    {
                        TempData["BookingAdd"] = "Booking Added Successful";
                        return RedirectToAction("GetBooking");
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



        public CustomerTb CustomerName(int id)
        {
           CustomerTb name = _bookingRepository.GetCustomerName(id);
            return name;    
        }

        public List<DroneLocationTb> GetDroneLocation() {
           List<DroneLocationTb> droneLocations= _bookingRepository.GetDroneLocation();
            return droneLocations;

        }

        public List<DroneShotTb> GetShot()
        {
            List<DroneShotTb> droneShot = _bookingRepository.GetShots();
            return droneShot;

        }
    }
}
