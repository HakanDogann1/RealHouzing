using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.HeaderDtos
{
    public class UpdateHeaderDto
    {
        public int HeaderID { get; set; }
        public string HeaderTitle1 { get; set; }
        public string HeaderTitle2 { get; set; }
        public string ImageUrl { get; set; }
    }
}
