using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
    public class REG_Module : IModule
    {
        public string GetModuleLead()
        {
            return "Eswar";
        }
    }
}
