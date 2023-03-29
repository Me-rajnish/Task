using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class CustomerTb:AuditTb
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerCode
        {
            get
            {
                return "CUST" + CustomerId.ToString("D4");
            }
        }
        [DisplayName("FirstName")]
        [Required(ErrorMessage = "First Name is required")]
        [MinLength(3, ErrorMessage = "First Name must at least 3 characters")]
        [MaxLength(150, ErrorMessage = "First Name must less than 150 characters")]
        [RegularExpression(@"^([a-zA-Z])*$", ErrorMessage = "First Name must contain only alphabet")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage ="Last Name is required")]
        [MinLength(3,ErrorMessage ="Last Name must contain at least 3 characters")]
        [MaxLength(200,ErrorMessage ="Last Name must less than 200 characters")]
        [RegularExpression(@"^([a-zA-Z])*$",ErrorMessage ="Last Name must contain only alphabet")]
        public string LastName { get; set; }



        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]

        [RegularExpression(@"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})*$", ErrorMessage = "Please Enter A Valid Email Address")]
        public string Email { get; set; }
        [DisplayName("Mobile")]
        [RegularExpression(@"^[6-9]{1}[0-9]{9}$", ErrorMessage = "Please Enter A Valid Mobile Number")]
        [Required(ErrorMessage = "Mobile is required")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Gender is required")]

        public string Gender { get; set; }
        public bool IsDeleted { get; set; } = false;
       



    }
}
