﻿using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.DataAccessLAyer.Repositories;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLAyer.EntityFramework
{
    public class EfAboutService1Dal:GenericRepository<AboutService1>,IAboutService1Dal
    {
    }
}
