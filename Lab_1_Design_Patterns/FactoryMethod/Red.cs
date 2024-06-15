using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.FactoryMethod
{
    public class Red : Color
    {
        public string GetColor()
        {
            return "Color is Red.";
        }
        // Factory Method
    }
}
