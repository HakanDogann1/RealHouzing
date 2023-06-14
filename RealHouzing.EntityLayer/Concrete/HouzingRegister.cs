﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class HouzingRegister
    {
        public int HouzingRegisterID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
