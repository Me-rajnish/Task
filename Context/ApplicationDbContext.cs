using Microsoft.EntityFrameworkCore;
using Task2.Models;

namespace Task2.Context
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext):base(dbContext)
        {
            
        }

        public DbSet<CustomerTb> CustomerTbs { get; set; }
        public DbSet<DroneLocationTb> DroneLocationTbs { get; set; }
        public DbSet<DroneShotTb> DroneShotTbs { get; set; }
        public DbSet<BookingCustomerTb> BookingCustomerTbs { get; set; }    
    }
}
