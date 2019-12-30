using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSDP
{
    public class DMS_Module:ProjectLead_1,IEmployee
    {
        public new string Designation()
        {
            return "DMS Module, My Boss is Project Lead 1";
        }
    }
}
