﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSDP
{
    public class Bridge
    {
        public string ReachTo(IGodavari obj)
        {
            return obj.Reach();
        }
    }
}
