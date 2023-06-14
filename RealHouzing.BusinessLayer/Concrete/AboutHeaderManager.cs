using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class AboutHeaderManager : IAboutHeaderService
    {
        private readonly IAboutHeaderDal _aboutHeaderDal;

        public AboutHeaderManager(IAboutHeaderDal aboutHeaderDal)
        {
            _aboutHeaderDal = aboutHeaderDal;
        }

        public void TDelete(AboutHeader entity)
        {
            _aboutHeaderDal.Delete(entity);
        }

        public AboutHeader TGetById(int id)
        {
            return _aboutHeaderDal.GetById(id);
        }

        public List<AboutHeader> TGetList()
        {
            return _aboutHeaderDal.GetList();
        }

        public void TInsert(AboutHeader entity)
        {
            _aboutHeaderDal.Insert(entity);
        }

        public void TUpdate(AboutHeader entity)
        {
            _aboutHeaderDal.Update(entity);
        }
    }
}
