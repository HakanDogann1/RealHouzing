using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.AboutQuestionHeaderDtos
{
    public class UpdateAboutQuestionHeaderDto
    {
        public int AboutQuestionHeaderID { get; set; }
        public string AboutQuestionHeaderTitle { get; set; }
        public string AboutQuestionHeaderDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
