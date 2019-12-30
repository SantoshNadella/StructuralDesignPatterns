using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSDP
{
    public class BreadProvider : IBread
    {
        public string GetCheesyGarlicBread()
        {
            return "Getting Garlic Bread.";
        }
        public string GetGarlicBread()
        {
            return GetCheese()+" & Getting Cheesy Garlic Bread.";
        }
        private string GetCheese()
        {
            return "Getting Cheese";
        }
    }
}
