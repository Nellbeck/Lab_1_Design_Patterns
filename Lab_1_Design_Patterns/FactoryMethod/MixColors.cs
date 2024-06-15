using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Design_Patterns.FactoryMethod
{
    public class MixColors
    {
        public Color CreateColor(MoreColors moreColors)
        {
            switch (moreColors)
            {
                case MoreColors.Grey:
                    Console.WriteLine("GreyRed was created.");
                    return new Red();

                case MoreColors.Yellow:
                    Console.WriteLine("YellowGreen was created.");
                    return new Green();

                case MoreColors.Purple:
                    Console.WriteLine("PurpleBlue was created.");
                    return new Blue();

                default:
                    throw new NotSupportedException();
                
                // Factory Method
            }
        }
    }
}
