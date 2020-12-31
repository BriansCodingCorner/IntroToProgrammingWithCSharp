using System;
using Lesson7.Helpers;
using Lesson7.Objects;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureReading tr = new TemperatureReading(0, TemperatureHelper.ToCelsius(32));
            TemperatureReading tr2 = new TemperatureReading(1, TemperatureHelper.ToCelsius(70));
            TemperatureReading tr3 = new TemperatureReading(2, TemperatureHelper.ToCelsius(90));

            Console.WriteLine(tr3.ToFahrenheit());

            tr3.FromFahrenheit(85);

            Console.WriteLine(tr3.ToFahrenheit());
        }
    }
}
