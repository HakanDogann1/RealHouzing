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
    public class AboutQuestionManager : IAboutQuestionService
    {
        private readonly IAboutQuestionDal _aboutQuestionDal;

        public AboutQuestionManager(IAboutQuestionDal aboutQuestionDal)
        {
            _aboutQuestionDal = aboutQuestionDal;
        }

        public void TDelete(AboutQuestion entity)
        {
            _aboutQuestionDal.Delete(entity);
        }

        public AboutQuestion TGetById(int id)
        {
            return _aboutQuestionDal.GetById(id);
        }

        public List<AboutQuestion> TGetList()
        {
            return _aboutQuestionDal.GetList();
        }

        public void TInsert(AboutQuestion entity)
        {
            _aboutQuestionDal.Insert(entity);
        }

        public void TUpdate(AboutQuestion entity)
        {
            _aboutQuestionDal.Update(entity);
        }
    }
}
