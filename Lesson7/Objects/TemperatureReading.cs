using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Objects
{
    public class TemperatureReading
    {
        public TemperatureReading() { }

        public TemperatureReading(
            int hourOfDay,
            double temperatureInCelsius)
        {
            HourOfDay = hourOfDay;
            Temperature = temperatureInCelsius;
        }

        public double Temperature { get; set; }
        public int HourOfDay { get; set; }
    }
}
