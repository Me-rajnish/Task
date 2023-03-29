using Task2.Context;
using Task2.Models;

namespace Task2.Repository
{
    public class BookingRepository:IBookingRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public BookingRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public bool BookingAdd(BookingCustomerTb booking)
        {
            var data = _applicationDbContext.BookingCustomerTbs.Add(booking);
            int IsAdd = _applicationDbContext.SaveChanges();
            if (IsAdd > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<DroneLocationTb> GetDroneLocation()
        {
            List<DroneLocationTb> droneLocationTbs= new List<DroneLocationTb>();    
            droneLocationTbs=_applicationDbContext.DroneLocationTbs.ToList();
            return droneLocationTbs;    
        }

        public CustomerTb GetCustomerName(int id)
        {
         CustomerTb customerTb= _applicationDbContext.CustomerTbs.Where(x => x.CustomerId == id).FirstOrDefault();
            return customerTb;
        }
        public List<DroneShotTb> GetShots()
        {
            List<DroneShotTb> droneShots = new List<DroneShotTb>();
            droneShots = _applicationDbContext.DroneShotTbs.ToList();
            return droneShots;
        }
    }
}
