using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class DroneLocationTb
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationCode
        {
            get
            {
                return "LOC" + LocationId.ToString("D4");
            }
        }
        public string LocationName { get; set; }    

        public string Address { get; set; }  
        public string State { get; set; }
        public string City { get; set; }

    }

}
