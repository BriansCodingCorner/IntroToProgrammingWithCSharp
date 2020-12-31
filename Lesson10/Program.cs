using System;
using System.Text;
using Lesson10Library.Objects;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daily Temperature Calculator");
            Console.WriteLine("");
            Console.WriteLine("(C)elsius or (F)ahrenheit?");
            string inputValue = Console.ReadLine();

            bool workingInCelsius = false;
            string readingType = "Fahrenheit";
            
            if (inputValue.Length > 1)
            {
                inputValue = inputValue.Substring(0, 1);
            }

            if (inputValue.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                workingInCelsius = true;
                readingType = "Celsius";
            }

            Day day = new Day();

            for (int i = 0; i < 24; i++)
            {
                bool done = false;

                while(!done)
                {
                    Console.WriteLine($"Enter the temperature for hour {i} in {readingType}");

                    inputValue = Console.ReadLine();

                    if (double.TryParse(inputValue, out double doubleValue))
                    {
                        double temperatureReading = doubleValue;

                        if (workingInCelsius)
                        {
                            day.SetReading(i, temperatureReading);
                        }
                        else
                        {
                            day.SetReadingFromFahrenheit(i, temperatureReading);
                        }

                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value entered.");
                    }
                }               
            }

            //Console.WriteLine(day.GetReadingInFahrenheit(0));

            //double minTemp = day.FindMinTemperatureInFahrenheit();
            //double maxTemp = day.FindMaxTemperatureInFahrenheit();
            //double avgTemp = day.CalculateAverageTemperatureInFahrenheit();

            double minTemp;
            double maxTemp;
            double avgTemp;

            if (workingInCelsius)
            {
                minTemp = day.FindMinTemperatureInCelsius();
                maxTemp = day.FindMaxTemperatureInCelsius();
                avgTemp = day.CalculateAverageTemperatureInCelsius();
            } 
            else
            {
                minTemp = day.FindMinTemperatureInFahrenheit();
                maxTemp = day.FindMaxTemperatureInFahrenheit();
                avgTemp = day.CalculateAverageTemperatureInFahrenheit();
            }

            //Write output to console
            Console.WriteLine($"Minimum temperature - {minTemp} in {readingType}");
            Console.WriteLine($"Maximum temperature - {maxTemp} in {readingType}");
            Console.WriteLine($"Average temperature - {avgTemp} in {readingType}");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 24; i++)
            {
                double value;

                if (workingInCelsius)
                {
                    value = day.GetReadingInCelsius(i);
                }
                else
                {
                    value = day.GetReadingInFahrenheit(i);
                }

                sb.AppendLine($"Hour {i} - {value} in {readingType}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
