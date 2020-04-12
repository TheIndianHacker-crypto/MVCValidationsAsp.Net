using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationinMVCLooslyBinding.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Enter Your Name")]
        [Display(Name = "name")]
        [DataType(DataType.Text)]
        public string name { get; set; }

        [NikhilCustomrValidation]      
        public string Classs { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter Your Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Your PhoneNumber")]
        [Range (1,100)]
        [Display(Name = "age")]
        
        public int age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}