using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.Singelton
{
    public class AccessPrivateColor
    {
        public static void GetAccessPrivateColor() 
        {
            PrivateColor p1 = PrivateColor.GetPrivateColor();
            PrivateColor p2 = PrivateColor.GetPrivateColor();

            if (p1 == p2) 
            {
                Console.WriteLine("Singelton works!");
            }
            else 
            {
                Console.WriteLine("Singelton failed!");
            }
            p1.RainbowColor();
            // Singelton
        }
    }
}
