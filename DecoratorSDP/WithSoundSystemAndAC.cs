using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSDP
{
    public class WithSoundSystemAndAC:WithAC
    {
        public override string CarType()
        {
            return base.CarType()+" With Sound System";
        }
    }
}
