using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Objects
{
    public class TestClass
    {
        //Class level variable
        double classLevel = 0.5;

        public void TestFunction()
        {
            //Method Level variable
            double methodLevel = 5;

            double value = methodLevel * classLevel;
        }

        public void TestFunctionTwo()
        {
            double methodLevel = 8;

            double value = methodLevel * classLevel;

            for (int i = 0; i < 24; i++)
            {
                double blockLevel = i * methodLevel * classLevel;
                
                double value2 = blockLevel;
            }            
        }

        public bool AboveMax(double testValue)
        {
            if (testValue > Globals.MaxTemperature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
