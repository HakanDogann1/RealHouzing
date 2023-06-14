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
    public class PropertyManager : IPropertyService
    {
        private readonly IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public void TDelete(Property entity)
        {
            _propertyDal.Delete(entity);
        }

        public Property TGetById(int id)
        {
            return _propertyDal.GetById(id);
        }

        public List<Property> TGetList()
        {
            return _propertyDal.GetList();
        }

        public void TInsert(Property entity)
        {
            _propertyDal.Insert(entity);
        }

        public void TUpdate(Property entity)
        {
            _propertyDal.Update(entity);
        }
    }
}
