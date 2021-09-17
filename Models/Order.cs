using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(15)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage ="Invalid input")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        [StringLength(100)]
        [Display(Name = "Address")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your Pincode")]
        [StringLength(6, MinimumLength = 6)]
        [RegularExpression("^[0-9] +$", ErrorMessage ="Invalid input")]
        [Display(Name = "Pin code")]
        public string Pincode { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        [Required(ErrorMessage = "Please enter your City")]
        [StringLength(50)]
        public string City { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        [Required(ErrorMessage = "Please enter your State")]
        [StringLength(50)]
        public string State { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid input")]
        [Required(ErrorMessage = "Please enter your Country")]
        [StringLength(50)]
        public string Country { get; set; }
        
        [Required(ErrorMessage = "Please enter your Phone number")]
        [StringLength(10, MinimumLength = 10)]
        [RegularExpression("^[0-9] +$", ErrorMessage = "Invalid input")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your Email ")]
        [StringLength(25)]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

    }
}
