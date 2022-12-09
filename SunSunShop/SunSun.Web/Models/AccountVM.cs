using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SunSun.Web.Models
{
    public class AccountVM
    {
        [Required(ErrorMessage = "Phone cannot be blank!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email cannot be blank!")]
        [EmailAddress(ErrorMessage ="Invalid Emial")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
       
    }
}