using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class ServicePlan
    {
        public int ServicePlanID { get; set; }
        public string ServicePlanTitle { get; set; }
        public string ServicePlanPrice { get; set; }
        public string ServicePlanIcon { get; set; }
        public int ServicePlanListing { get; set; }
        public int ServicePlanFeatureListing { get; set; }
    }
}
