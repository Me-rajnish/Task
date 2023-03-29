using Task2.Models;

namespace Task2.Repository
{
    public interface IDroneRepository
    {
        bool CustomerAdd(CustomerTb customer);
        List<CustomerTb> GetCustomers();
        CustomerTb GetCustomerById(int id);
        bool UpdateCustomer(CustomerTb customer);
        bool DeleteCustomer(int id);
    }
      
}
