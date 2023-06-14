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
    public class AboutQuestionHeaderManager : IAboutQuestionHeaderService
    {
        private readonly IAboutQuestionHeaderDal _aboutQuestionHeaderDal;

        public AboutQuestionHeaderManager(IAboutQuestionHeaderDal aboutQuestionHeaderDal)
        {
            _aboutQuestionHeaderDal = aboutQuestionHeaderDal;
        }

        public void TDelete(AboutQuestionHeader entity)
        {
            _aboutQuestionHeaderDal.Delete(entity);
        }

        public AboutQuestionHeader TGetById(int id)
        {
            return _aboutQuestionHeaderDal.GetById(id);
        }

        public List<AboutQuestionHeader> TGetList()
        {
            return _aboutQuestionHeaderDal.GetList();
        }

        public void TInsert(AboutQuestionHeader entity)
        {
            _aboutQuestionHeaderDal.Insert(entity);
        }

        public void TUpdate(AboutQuestionHeader entity)
        {
           _aboutQuestionHeaderDal.Update(entity);
        }
    }
}
