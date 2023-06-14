using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.Property3Dtos
{
    public class UpdateProperty3Dto
    {
        public int Property3ID { get; set; }
        public string Property3Title { get; set; }
        public string Property3Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
