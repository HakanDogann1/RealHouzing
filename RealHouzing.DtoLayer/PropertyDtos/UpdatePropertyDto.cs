using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.PropertyDtos
{
    public class UpdatePropertyDto
    {
        public int PropertyID { get; set; }
        public string PropertyTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
