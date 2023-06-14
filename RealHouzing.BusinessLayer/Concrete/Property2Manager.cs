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
    public class Property2Manager : IProperty2Service
    {
        private readonly IProperty2Dal _property2Dal;

        public Property2Manager(IProperty2Dal property2Dal)
        {
            _property2Dal = property2Dal;
        }

        public void TDelete(Property2 entity)
        {
            _property2Dal.Delete(entity);
        }

        public Property2 TGetById(int id)
        {
            return _property2Dal.GetById(id);
        }

        public List<Property2> TGetList()
        {
            return _property2Dal.GetList();
        }

        public void TInsert(Property2 entity)
        {
            _property2Dal.Insert(entity);
        }

        public void TUpdate(Property2 entity)
        {
            _property2Dal.Update(entity);
        }
    }
}
