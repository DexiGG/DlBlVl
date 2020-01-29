﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaveTime.Web.Admin.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BranchAddress { get; set; }
        public string AccountPhone { get; set; }
        public string AccountEmail { get; set; }
        public string BranchPhone { get; set; }
    }
}