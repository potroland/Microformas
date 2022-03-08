using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microformas.Model
{
    public class DTO_Nationalize
    {
        public List<country> country { get; set; }
    }

    public class country 
    {
        public string country_id { get; set; }
        public string probability { get; set; }
    }
}
