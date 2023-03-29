using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task2.Models
{
    public class BookingCustomerTb:AuditTb
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        [ForeignKey("LocationId")]
        public int location_Id { get; set; }
        [ForeignKey("DronShotId")]
        public int drone_shot_id { get; set; }
       

        public virtual CustomerTb CustomerTb { get; set; }  
        public virtual DroneLocationTb DroneLocationTb { get; set; }
        public virtual DroneShotTb DroneShotTb { get; set; }

   


    }
}
