using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureReading temp1 = new TemperatureReading();
            temp1.HourOfDay = 1;
            temp1.SetTemperatureFromFahrenheit(90); //Temp in F.

            TemperatureReading temp2 = new TemperatureReading(2, 30); //Temp in C
            TemperatureReading temp3 = new TemperatureReading(3, 28); //Temp in C

            TemperatureReading[] temps = new TemperatureReading[24];
            //temps[0] = new TemperatureReading(0, 16);
            //temps[1] = new TemperatureReading(1, 17);
            //temps[2] = new TemperatureReading(2, 18);

            for(int i = 0; i< 24; i++)
            {
                temps[i] = new TemperatureReading(i, 0);
            }



        }
    }
}
