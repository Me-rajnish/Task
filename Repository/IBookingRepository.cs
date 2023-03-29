using Task2.Models;

namespace Task2.Repository
{
    public interface IBookingRepository
    {
        bool BookingAdd(BookingCustomerTb booking);

        List<DroneLocationTb> GetDroneLocation();
        List<DroneShotTb> GetShots();
        CustomerTb GetCustomerName(int id);
       
    }
}
