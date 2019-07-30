using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalX.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="E-Mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name ="Driving License Registration Number")]
        [MaxLength(10)]
        [MinLength(10)]
        public string DrivingLicenseNumber { get; set; }

        public int Points { get; set; }

        [Required]
        [Display(Name ="Birth Date")]
        public DateTime Birthdate { get; set; }
    }
}