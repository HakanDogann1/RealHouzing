using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using RealHouzing.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealHouzing.DataAccessLayer.EntityFramework;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class HouzingRegisterManager : IHouzingRegisterService
    {
        private readonly IHouzingRegisterDal _houzingRegisterDal;

        public HouzingRegisterManager(IHouzingRegisterDal houzingRegisterDal)
        {
            _houzingRegisterDal= houzingRegisterDal;
        }

        public void TDelete(HouzingRegister entity)
        {
            _houzingRegisterDal.Delete(entity);
        }

        public HouzingRegister TGetById(int id)
        {
            return _houzingRegisterDal.GetById(id);
        }

        public List<HouzingRegister> TGetList()
        {
           return _houzingRegisterDal.GetList();
        }

        public List<HouzingRegister> TGetRegistrations(int id)
        {
            return _houzingRegisterDal.GetRegistrations(id);
        }

        public void TInsert(HouzingRegister entity)
        {
            _houzingRegisterDal.Insert(entity);
        }

        public void TUpdate(HouzingRegister entity)
        {
           _houzingRegisterDal.Update(entity);
        }
    }
}
