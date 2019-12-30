using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSDP
{
    public class ProjectLead_1:Director,IEmployee
    {
        public override string Designation()
        {
            return "Project Lead 1, My Boss is Director";
        }
    }
}
