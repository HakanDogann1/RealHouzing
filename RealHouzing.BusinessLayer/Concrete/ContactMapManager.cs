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
    public class ContactMapManager : IContactMapService
    {
        private readonly IContactMapDal _contactMapDal;

        public ContactMapManager(IContactMapDal contactMapDal)
        {
            _contactMapDal = contactMapDal;
        }

        public void TDelete(ContactMap entity)
        {
            _contactMapDal.Delete(entity);
        }

        public ContactMap TGetById(int id)
        {
            return _contactMapDal.GetById(id);
        }

        public List<ContactMap> TGetList()
        {
            return _contactMapDal.GetList();
        }

        public void TInsert(ContactMap entity)
        {
            _contactMapDal.Insert(entity);
        }

        public void TUpdate(ContactMap entity)
        {
            _contactMapDal.Update(entity);
        }
    }
}
