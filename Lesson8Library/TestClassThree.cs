using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Library
{
    internal class TestClassThree
    {
        public TestClassThree()
        {
            Name = "Set name";
        }

        public string Name { get; internal set; }
    }
}
