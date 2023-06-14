using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.ContactChannelDtos
{
    public class UpdateContactChannelDto
    {
        public int ContactChannelID { get; set; }
        public string ContactChannelTitle { get; set; }
        public string ContactChannelDescription { get; set; }
        public string Icon { get; set; }
    }
}
