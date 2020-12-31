using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class TemperatureReading
    {
        private double _temperature;

        public TemperatureReading()
        {
        }

        public TemperatureReading(
            int hourOfDay,
            double temperatureCelisus)
        {
            HourOfDay = hourOfDay;
            _temperature = temperatureCelisus;
        }

        public double ToCelsius(double temperatureFahrenheit)
        {
            double temperatureCelisus = (5.0 / 9.0) * (temperatureFahrenheit - 32.0);
            return temperatureCelisus;
        }

        public double ToFahrenheit(double temperatureCelsius)
        {
            double temperatureFahrenheit = (9.0 / 5.0) * temperatureCelsius + 32.0;
            return temperatureFahrenheit;
        }

        public void SetTemperatureFromFahrenheit(double temperatureFahrenheit)
        {
            Temperature = ToCelsius(temperatureFahrenheit);
        }


        public int HourOfDay { get; set; }

        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
            }
        }
        
    }
}
