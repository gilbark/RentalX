using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentalX.Models
{
    public class Car
    {
        public int Id { get; set; }

        [ForeignKey("CarClass")]
        [Display(Name = "Class")]
        public int ClassId { get; set; }


        public CarClass CarClass { get; set; }

        [ForeignKey("Make")]
        [Display(Name = "Make")]
        public int MakeId { get; set; }

        public CarMake Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        public long CarMileage { get; set; }

        [Required]
        public int CostPerDay { get; set; }
    }
}