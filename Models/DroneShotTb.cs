using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class DroneShotTb
    {
        [Key]
        public int DronShotId { get; set; }
        public string DronShotCode
        {
            get
            {
                return "SHOT" + DronShotId.ToString("D4");
            }
        }
           
        public string DroneShotName { get; set; }

        //Description of the drone shot
        public string Description { get; set; }
        //Price of the drone shot
        public decimal Price { get; set; }
       // Duration of the drone shot in minutes
        public int DurationInMinutes { get; set; }

        //Maximum speed in miles per hour that the drone can fly for the shot
        public int MaxSpeedInMPH { get; set; }

        //Maximum number of passengers that can be in the shot
        public int MaxNumberOfPassengers { get; set; }
    }
}
