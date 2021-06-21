using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zoomer.Models
{
    public class BodyStyle
    {
        
        public byte Id { get; set; }
        [Display(Name = "Body Type")]
        public string BodyType { get; set; }
    }
}