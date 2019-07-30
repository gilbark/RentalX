using RentalX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalX.ViewModels
{
    public class CarFormViewModel
    {
        public int? Id { get; set; } // Nullable, DB can auto-increment

        [Required]
        [StringLength(255)]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }



        public IEnumerable<CarClass> Classes { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int ClassId { get; set; }


        public IEnumerable<CarMake> Make { get; set; }

        [Required]
        [Display(Name = "Maker")]
        public int MakeId { get; set; }


        [Required]
        public int? CarMileage { get; set; } 

        [Required]
        [Display(Name = "Cost Per Day")]
        public int? CostPerDay { get; set; }

        public CarFormViewModel()
        {
            Id = 0;
        }

        public CarFormViewModel(Car car)
        {
            Id = car.Id;
            CarModel = car.CarModel;
            MakeId = car.MakeId;
            ClassId = car.ClassId;
            CarMileage = car.CarMileage;
            CostPerDay = car.CostPerDay;
        }
    }
}