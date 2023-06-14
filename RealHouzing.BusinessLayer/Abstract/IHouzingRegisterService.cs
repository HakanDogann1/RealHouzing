using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Abstract
{
    public interface IHouzingRegisterService:IGenericService<HouzingRegister>
    {
        List<HouzingRegister> TGetRegistrations(int id);
    }
}
