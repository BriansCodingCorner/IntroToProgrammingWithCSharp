using System;
using System.Text;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Interpolation
            string name = "Brian";
            string location = "the US";

            string output = $"{name} lives in {location}";

            Console.WriteLine(output);

            int frogsInPond = 15;

            output = $"There are {frogsInPond} frogs in the pond";
            Console.WriteLine(output);


            //Building Large strings - Wrong way
            string bigOutput = "";
            for (int i = 0; i < 100; i++)
            {
                bigOutput = bigOutput + " " +  i.ToString();
            }
            Console.WriteLine(bigOutput);

            //Building Large Strings - Correct Way
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            output = sb.ToString();
            Console.WriteLine(output);

            //Conversion
            int counter = Convert.ToInt32("1");
            double testDouble = Convert.ToDouble("2.5");

            string conversionOutput = Convert.ToString(counter);
            Console.WriteLine(conversionOutput);

            conversionOutput = Convert.ToString(testDouble);
            Console.WriteLine(conversionOutput);
        }
    }
}
