﻿using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLAyer.Repositories;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EfAboutQuestionDal:GenericRepository<AboutQuestion>,IAboutQuestionDal
    {
    }
}
