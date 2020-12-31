using System;
using System.Collections.Generic;
using System.Text;
using Lesson10Library.Helpers;

namespace Lesson10Library.Objects
{
    public class Day
    {
        private TemperatureReading[] _readings;

        public Day()
        {
            _readings = new TemperatureReading[24];
        }

        public double GetReadingInCelsius(int hourOfDay)
        {
            TemperatureReading reading = _readings[hourOfDay];

            if (reading == null)
            {
                return 0;
            }

            return reading.Temperature;
        }

        public double GetReadingInFahrenheit(int hourOfDay)
        {
            TemperatureReading reading = _readings[hourOfDay];

            if (reading == null)
            {
                return 0;
            }

            return reading.ToFahrenheit();
        }

        public void SetReading(int hourOfDay, double temperatureInCelsius)
        {
            TemperatureReading reading = new TemperatureReading();
            reading.HourOfDay = hourOfDay;
            reading.Temperature = temperatureInCelsius;

            _readings[hourOfDay] = reading;
        }

        public void SetReadingFromFahrenheit(int hourOfDay, double temperatureInFahrenheit)
        {
            SetReading(hourOfDay, TemperatureHelper.ToCelsius(temperatureInFahrenheit));
        }

        public double FindMaxTemperatureInCelsius()
        {
            double maxTemp = Double.MinValue;

            for (int i = 0; i < 24; i++)
            {
                TemperatureReading reading = _readings[i];

                if (reading != null)
                {
                    if (reading.Temperature> maxTemp)
                    {
                        maxTemp = reading.Temperature;    
                    }
                }
            }

            return maxTemp;
        }

        public double FindMaxTemperatureInFahrenheit()
        {
            return TemperatureHelper.ToFahrenheit(FindMaxTemperatureInCelsius());
        }

        public double FindMinTemperatureInCelsius()
        {
            double minValue = Double.MaxValue;

            for (int i = 0; i < 24; i++)
            {
                TemperatureReading reading = _readings[i];

                if (reading != null)
                {
                    if (reading.Temperature < minValue)
                    {
                        minValue = reading.Temperature;
                    }
                }
            }

            return minValue;
        }

        public double FindMinTemperatureInFahrenheit()
        {
            return TemperatureHelper.ToFahrenheit(FindMinTemperatureInCelsius());
        }

        public double CalculateAverageTemperatureInCelsius()
        {
            int hours = 0;
            double sum = 0.0;

            for (int i = 0; i < 24; i++)
            {
                TemperatureReading reading = _readings[i];

                if (reading != null)
                {
                    hours++;
                    sum += reading.Temperature;                    
                }
            }

            double average = sum / hours;
            return average;
        }

        public double CalculateAverageTemperatureInFahrenheit()
        {
            return TemperatureHelper.ToFahrenheit(CalculateAverageTemperatureInCelsius());
        }



    }
}
