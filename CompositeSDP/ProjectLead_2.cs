using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSDP
{
    public class ProjectLead_2:Director,IEmployee
    {
        public override string Designation()
        {
            //return base.Designation();
            return "Project lead 2, My boss is"+base.Designation();
        }
    }
}
