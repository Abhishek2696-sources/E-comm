using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMARTECOMM.Areas.Admin.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       // [DataType(DataType.Password)]
       // [Display(Name ="Confirm Password")]
        //[Compare("Password",ErrorMessage ="")]
        public string ConfirmPassword { get; set; }

      //  [Required(ErrorMessage = "Please enter first name")]
      //  [StringLength(20, ErrorMessage = "First name length is 20 characters.")]
       // [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Plese enter valid first Name")]
        public string Name { get; set; } 

       // [StringLength(14, ErrorMessage = "Phone number length is 14 digits.")]
        public string PhoneNumber { get; set; }
    }
}
