﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.AboutHeader
{
    public class UpdateAboutHeaderDto
    {
        public int AboutHeaderID { get; set; }
        public string AboutHeaderTitle1 { get; set; }
        public string AboutHeaderTitle2 { get; set; }
        public string ImageUrl { get; set; }
    }
}
