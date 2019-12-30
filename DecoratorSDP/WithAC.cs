using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSDP
{
    public class WithAC:Car
    {
        public override string CarType()
        {
            // return base.CarType();
            return "AC Car"; 
        }
    }
}
