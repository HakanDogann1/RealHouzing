using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ContactMapDtos
{
    public class UpdateContactMapDto
    {
        public int ContactMapID { get; set; }
        public string ContactLocationName { get; set; }
        public string ContactMapLocation { get; set; }

        public bool Status { get; set; }
    }
}
