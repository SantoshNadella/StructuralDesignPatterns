using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
    class ModuleLeadAdaptor : IModule
    {
        public string GetModuleLead()
        {
            throw new NotImplementedException();
        }
        public string GetModuleLead(IModule obj)
        {
            return obj.GetModuleLead();
        }
    }
}
