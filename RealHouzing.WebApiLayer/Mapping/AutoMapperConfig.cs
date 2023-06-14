using AutoMapper;
using RealHouzing.DtoLayer.AboutDtos;
using RealHouzing.DtoLayer.AboutHeader;
using RealHouzing.DtoLayer.AboutQuestionDtos;
using RealHouzing.DtoLayer.AboutQuestionHeaderDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.WebApiLayer.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
            CreateMap<AddAboutHeaderDto, AboutHeader>().ReverseMap();
            CreateMap<UpdateAboutHeaderDto, AboutHeader>().ReverseMap();
            CreateMap<ResultAboutQuestionDto,AboutQuestion>().ReverseMap();
            CreateMap<UpdateAboutQuestionDto,AboutQuestion>().ReverseMap();
            CreateMap<ResultAboutQuestionHeaderDto,AboutQuestionHeader>().ReverseMap();
            CreateMap<UpdateAboutQuestionHeaderDto,AboutQuestionHeader>().ReverseMap();
        }
    }
}
