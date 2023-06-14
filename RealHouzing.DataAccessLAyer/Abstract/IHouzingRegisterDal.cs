using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Abstract
{
    public interface IHouzingRegisterDal:IGenericDal<HouzingRegister>
    {
        List<HouzingRegister> GetRegistrations(int id);
    }
}
