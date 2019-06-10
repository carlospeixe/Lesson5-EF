using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson5_EF.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Required]
        [Display(Name ="Car Brand")]
        public string Brand { get; set; }
        [Required]
        [Display(Name ="Car Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name ="Car Type")]
        public string Type { get; set; }
        [Required]
        [Range(1990,2020)]
        [Display(Name ="Car Year")]
        public int Year { get; set; }
    }
}