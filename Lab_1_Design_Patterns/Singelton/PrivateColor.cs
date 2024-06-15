using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.Singelton
{
    public sealed class PrivateColor
    {
        private PrivateColor() { }

        private static PrivateColor _color;

        public static PrivateColor GetPrivateColor()
        {
            if (_color == null)
            {
                _color = new PrivateColor();
            }
            return _color;

        }
        public void RainbowColor () 
        {
            Console.WriteLine("A rainbow have alot of colors!");
        }
        // Singelton
    }
}
