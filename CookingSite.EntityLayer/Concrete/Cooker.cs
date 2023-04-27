using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSite.EntityLayer.Concrete
{
    public class Cooker
    {
        public int CookerID { get; set; }
        public string CookerName { get; set; }
        public string CookerImageURL { get; set; }
        public int CookerRecipesCount { get; set; }
    }
}
