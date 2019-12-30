using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
   public class QMS_Module : IModule
    {
        public string GetModuleLead()
        {
            return "Naveen";
        }
    }
}
