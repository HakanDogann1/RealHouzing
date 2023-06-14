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
    public class ContactChannelManager : IContactChannelService
    {
        private readonly IContactChannelDal _contactChannelDal;

        public ContactChannelManager(IContactChannelDal contactChannelDal)
        {
            _contactChannelDal = contactChannelDal;
        }

        public void TDelete(ContactChannel entity)
        {
            _contactChannelDal.Delete(entity);
        }

        public ContactChannel TGetById(int id)
        {
            return _contactChannelDal.GetById(id);
        }

        public List<ContactChannel> TGetList()
        {
            return _contactChannelDal.GetList();
        }

        public void TInsert(ContactChannel entity)
        {
            _contactChannelDal.Insert(entity);
        }

        public void TUpdate(ContactChannel entity)
        {
            _contactChannelDal.Update(entity);
        }
    }
}
