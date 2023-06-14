using Microsoft.EntityFrameworkCore;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLAyer.Concrete;
using RealHouzing.DataAccessLAyer.Repositories;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EfHouzingRegisterDal : GenericRepository<HouzingRegister>, IHouzingRegisterDal
    {
        public List<HouzingRegister> GetRegistrations(int id)
        {
            using var context = new Context();
            return context.HouzingRegisters.Where(x=>x.AppUserID == id).Include(y=>y.AppUser).Include(z=>z.Product).ToList();
        }
    }
}
