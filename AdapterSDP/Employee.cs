using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
    public class Employee
    {
        public string LeadFor(IModule obj)
        {
            return new ModuleLeadAdaptor().GetModuleLead(obj);
        }
    }
}
