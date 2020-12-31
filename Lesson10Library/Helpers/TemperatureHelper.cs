using System;
using System.Collections.Generic;
using System.Text;
using Lesson10Library.Objects;

namespace Lesson10Library.Helpers
{
    public static class TemperatureHelper
    {
        public static double ToCelsius(double temperatureFahrenheit)
        {
            double temperatureCelisus = (5.0 / 9.0) * (temperatureFahrenheit - 32.0);
            return temperatureCelisus;
        }

        public static double ToFahrenheit(double temperatureCelsius)
        {
            double temperatureFahrenheit = (9.0 / 5.0) * temperatureCelsius + 32.0;
            return temperatureFahrenheit;
        }

        public static double ToFahrenheit(this TemperatureReading temperature)
        {
            return ToFahrenheit(temperature.Temperature);
        }

        public static void FromFahrenheit(this TemperatureReading temperature, double temperatureInFahrenheit)
        {
            temperature.Temperature = ToCelsius(temperatureInFahrenheit);
        }
    }
}
