﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; }
    }
}