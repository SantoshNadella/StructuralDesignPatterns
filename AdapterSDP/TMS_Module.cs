using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
    public class TMS_Module : IModule
    {
        public string GetModuleLead()
        {
            return "Praveen";
        }
    }
}
