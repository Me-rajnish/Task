using System.Security.AccessControl;
using System.Security.Authentication;
using Task2.Context;
using Task2.Models;

namespace Task2.Repository
{
    public class DroneRepository:IDroneRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DroneRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }   


        //Display a list of Customer
        public List<CustomerTb> GetCustomers()
        {
            List<CustomerTb> customerlist=_applicationDbContext.CustomerTbs.ToList();
            return customerlist;

        }

        public CustomerTb GetCustomerById(int id)
        {
           CustomerTb  customer=_applicationDbContext.CustomerTbs.Where(x=>x.CustomerId==id).FirstOrDefault();
            return customer;

        }
        public bool CustomerAdd(CustomerTb customer)
        {
          var data= _applicationDbContext.CustomerTbs.Add(customer);
            int IsAdd = _applicationDbContext.SaveChanges();
            if (IsAdd>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool UpdateCustomer(CustomerTb customer)

        {
            customer.UpdatedDate = DateTime.Now;
            _applicationDbContext.CustomerTbs.Update(customer); 
            int IsUpdate = _applicationDbContext.SaveChanges();
            if (IsUpdate > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool DeleteCustomer(int id)
        {
           CustomerTb customer= GetCustomerById(id);
            if (customer != null)
            {
                _applicationDbContext.CustomerTbs.Remove(customer);
                int IsUpdate = _applicationDbContext.SaveChanges();
                if (IsUpdate > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
