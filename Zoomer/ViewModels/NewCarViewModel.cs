using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zoomer.Models;

namespace Zoomer.ViewModels
{
    public class NewCarViewModel
    {
        public IEnumerable<BodyStyle> BodyStyles { get; set; }
        public Car Car { get; set; }

        public string PageTitle { 
            get
            {
                if (Car != null && Car.Id != 0)
                    return "Edit Car";
                return "New Car";
            }
        }
    }
}