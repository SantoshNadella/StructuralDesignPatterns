using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSDP
{
    public class PizzaProvider : IPizza
    {
        public string GetNonVegPizza()
        {
            return GetNonVegToppings()+" & Getting Non Veg Pizza.";
        }
        public string GetVegPizza()
        {
            return "Getting Veg Pizza";
        }
        public string GetNonVegToppings()
        {
            return "Getting Non Veg Pizza Toppings";
        }
    }
}
