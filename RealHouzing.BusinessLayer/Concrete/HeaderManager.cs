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
    public class HeaderManager : IHeaderService
    {
        private readonly IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void TDelete(Header entity)
        {
            _headerDal.Delete(entity);
        }

        public Header TGetById(int id)
        {
            return _headerDal.GetById(id);
        }

        public List<Header> TGetList()
        {
            return _headerDal.GetList();
        }

        public void TInsert(Header entity)
        {
            _headerDal.Insert(entity);
        }

        public void TUpdate(Header entity)
        {
            _headerDal.Update(entity);
        }
    }
}
