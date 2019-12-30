using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSDP
{
    public class UMS_Module : IModule
    {
        public string GetModuleLead()
        {
            return "Bhanu M";
        }
        //string IModule.GetModuleLead()
        //{
        //    return "Bhanu M";
        //}
    }
}
