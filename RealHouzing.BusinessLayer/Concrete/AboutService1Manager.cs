using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class AboutService1Manager : IAboutService1Service
    {
        private readonly IAboutService1Dal _aboutService1Dal;

        public AboutService1Manager(IAboutService1Dal aboutService1Dal)
        {
            _aboutService1Dal = aboutService1Dal;
        }

        public void TDelete(AboutService1 entity)
        {
            _aboutService1Dal.Delete(entity);
        }

        public AboutService1 TGetById(int id)
        {
            return _aboutService1Dal.GetById(id);
        }

        public List<AboutService1> TGetList()
        {
            return _aboutService1Dal.GetList();
        }

        public void TInsert(AboutService1 entity)
        {
            _aboutService1Dal.Insert(entity);
        }

        public void TUpdate(AboutService1 entity)
        {
            _aboutService1Dal.Update(entity);
        }
    }
}
