using System;
using Lesson8.Objects;
using Lesson8Library;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Globals.MaxTemperature = 40;

            //TestClass tc = new TestClass();

            //tc.TestFunction();
            //tc.TestFunctionTwo();

            //bool result = tc.AboveMax(50);
            //result = tc.AboveMax(40);
            //result = tc.AboveMax(30);

            TestClassOne one = new TestClassOne();
            one.ValueOne = "TestValueOne";
            //Console.WriteLine(one.PrivateValue);

            TestClassTwo two = new TestClassTwo();
            two.ValueTwo = "TestValueTwo";

            //TestClassThree three = new TestClassThree();
            //Console.WriteLine(three.Name);
        }
    }
}
