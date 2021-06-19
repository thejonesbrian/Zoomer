﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zoomer.Models;

namespace Zoomer.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}