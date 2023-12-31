﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String City { get; set; }
    }
}
