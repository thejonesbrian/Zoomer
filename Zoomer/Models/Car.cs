using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoomer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string YearOfMake { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}