﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.Strategy
{
    class ShadowColors : SpecialColor
    {
        public object ShadowColor (object data)
        {
            var list = data as List<string>;
            return list;
        }
    }
}