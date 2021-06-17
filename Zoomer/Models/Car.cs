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
        public string YearOfMake { get; set; }
        [Required]
        public DateTime? DateAdded { get; set; }
        [Required]
        public BodyStyle BodyStyle { get; set; }
    }
}