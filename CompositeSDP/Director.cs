using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSDP
{
    public class Director : IEmployee
    {
        public virtual string Designation()
        {
            return "Director Techinical Operations";
        }
    }
}
