using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microformas.Model
{
    public class DTO_Ubicaciones
    {
        
        public List<ubicaciones> ubicaciones { get; set; }

    }

    public class ubicaciones 
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string city { get; set; }
        public string description { get; set; }
    }
}
