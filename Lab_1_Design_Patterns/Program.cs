using Lab_1_Design_Patterns.FactoryMethod;
using Lab_1_Design_Patterns.Singelton;
using Lab_1_Design_Patterns.Strategy;

namespace Lab_1_Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory Method, Singelton, Strategy

            // Singelton Check.
            AccessPrivateColor.GetAccessPrivateColor();

            Console.WriteLine();

            // Factory Method Check.
            var Grey = MoreColors.Grey;
            MixColors mixColors = new MixColors();
            mixColors.CreateColor(Grey);

            Console.WriteLine();

            var colorContext = new ColorContext();

            //Unsorted ShadowColor
            colorContext.SetColors(new ShadowColors());
            colorContext.SetShadowColor();

            Console.WriteLine();

            //Sorted ShadowColor
            colorContext.SetColors(new ShadowColorsSorted());
            colorContext.SetShadowColor();
        }
    }
}
