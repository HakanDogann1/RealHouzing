using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLAyer.Abstract;
using RealHouzing.DataAccessLAyer.Repositories;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class Property3Manager : IProperty3Service
    {
        private readonly IProperty3Dal _property3Dal;

        public Property3Manager(IProperty3Dal property3Dal)
        {
            _property3Dal = property3Dal;
        }

        public void TDelete(Property3 entity)
        {
            _property3Dal.Delete(entity);
        }

        public Property3 TGetById(int id)
        {
            return _property3Dal.GetById(id);
        }

        public List<Property3> TGetList()
        {
            return _property3Dal.GetList();
        }

        public void TInsert(Property3 entity)
        {
            _property3Dal.Insert(entity);
        }

        public void TUpdate(Property3 entity)
        {
            _property3Dal.Update(entity);
        }
    }
}
