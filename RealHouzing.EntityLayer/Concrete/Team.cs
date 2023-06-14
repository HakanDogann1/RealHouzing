using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
    }
}
