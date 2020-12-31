using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Library
{
    public class TestClassOne
    {
        public TestClassOne()
        {
            PrivateValue = "Set in constructor";
        }

        public string ValueOne { get; set; }

        private string PrivateValue { get; set; }
    }
}
