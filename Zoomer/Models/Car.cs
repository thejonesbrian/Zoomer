using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoomer.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Year of Make")]
        public string YearOfMake { get; set; }
        [Required]
        [Display(Name ="Date Added")]
        public DateTime? DateAdded { get; set; }
        
        public BodyStyle BodyStyle { get; set; }
        [Required]
        [Display(Name = "Car Body Type")]
        public byte BodyStyleId { get; set; }
    }
}