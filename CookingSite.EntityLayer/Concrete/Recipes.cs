using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSite.EntityLayer.Concrete
{
    public class Recipes
    {
        public int RecipesID { get; set; }
        public string RecipesName { get; set; }
        public string RecipesImageURL { get; set; }
        public string RecipesReview { get; set; }
        public string RecipesServices { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
