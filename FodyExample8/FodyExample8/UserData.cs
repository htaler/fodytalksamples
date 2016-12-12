﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample8
{
    [ToString]
    public class UserData
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public DateTime BirthDate { get; set; }
        [IgnoreDuringToString]
        public string Password { get; set; }
    }
}
