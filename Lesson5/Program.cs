using System;
using System.Diagnostics.CodeAnalysis;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            double sum = 0;

            //double[] values = new double[] { 3.0, 6.0, 9.0, 12.0, 15.0, 18.0 };

            //for(int i = 0; i < values.Length; i++)
            //{
            //    sum += values[i];
            //    //sum = sum + i;
            //}

            //Console.WriteLine(sum);

            //While Loop
            bool done = false;
            int count = 13;

            //while (!done)
            //{
            //    sum += count;

            //    if (count > 10)
            //    {
            //        done = true;
            //    }

            //    count += 3;
            //}

            //while (count <= 12)
            //{
            //    sum += count;
            //    count += 3;
            //}

            do
            {
                sum += count;

                count += 3;
            } while (count < 12);


            Console.WriteLine(sum);

        }
    }
}
