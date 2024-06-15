using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.Strategy
{
    class ColorContext
    {
        private SpecialColor _color;
        public ColorContext() { }

        public ColorContext(SpecialColor specialColor) 
        { 
            _color = specialColor;
        }
        public void SetColors(SpecialColor specialColor)
        {
            _color = specialColor;
        }
        public void SetShadowColor() 
        {
            var result = _color.ShadowColor(
                new List<string> 
                {
                    "ShadowRed",
                    "ShadowBlue",
                    "ShadowGreen"
                });

            string list = string.Empty;
            foreach (var item in result as List<string>) 
            {
                list += item + ",";
            }
            Console.WriteLine(list);
            // Strategy
        }
    }
}
