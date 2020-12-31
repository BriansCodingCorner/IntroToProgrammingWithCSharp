using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 32;
            string description = "cold";

            //if (temperature<60.0)
            //{
            //    description = "Cold";
            //}
            //else if (temperature >= 60.0
            //    && temperature < 70)
            //{
            //    description = "Mild";
            //}
            //else if (temperature == 72.0)
            //{
            //    description = "Perfect";
            //}
            //else if (temperature >= 70.00
            //    && temperature < 80.00)
            //{
            //    description = "Nice";
            //} 
            //else if (temperature >= 80.0
            //    && temperature < 90.0)
            //{
            //    description = "Warm";
            //}
            //else
            //{
            //    description = "Hot";
            //}


            int tempRange = 5;

            //0 - Cold
            //1 - Mild
            //2 - Nice
            //3 - Warm
            //4 - Hot

            //if (tempRange == 0)
            //{
            //    description = "Temperature is less than 60";
            //}
            //else if (tempRange == 1)
            //{
            //    description = "Temperature is greater than or equal to 60 AND less than 70";
            //}
            //else if (tempRange == 2)
            //{
            //    description = "Temperature is greater than or equal to 70 AND less than 80";
            //}
            //else if (tempRange == 3)
            //{
            //    description = "Temperature is greater than or equal to 80 AND less than 90";
            //}
            //else if (tempRange == 4)
            //{
            //    description = "Temperature is greater than 90";
            //}

            switch (tempRange)
            {
                case 0:
                    description = "Temperature is less than 60";
                    break;
                case 1:
                    description = "Temperature is greater than or equal to 60 AND less than 70";
                    break;
                case 2:
                    description = "Temperature is greater than or equal to 70 AND less than 80";
                    break;
                case 3:
                    description = "Temperature is greater than or equal to 80 AND less than 90";
                    break;
                case 4:
                    description = "Temperature is greater than 90";
                    break;
                default:
                    description = "Unknown temperature range specified";
                    break;
            }

            Console.WriteLine(description);
        }
    }
}
