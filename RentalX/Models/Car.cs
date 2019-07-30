using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalX.Models
{
    public class Car
    {
        public int Id { get; set; }


        [Required]
        public int ClassId { get; set; }

        [Display(Name = "Class")]
        public CarClass CarClass { get; set; }


        [Required]
        public int MakeId { get; set; }

        public CarMake Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        [Required]
        public long CarMileage { get; set; }

        [Required]
        public int CostPerDay { get; set; }
    }
}