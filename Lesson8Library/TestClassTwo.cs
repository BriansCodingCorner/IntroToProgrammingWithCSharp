using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Library
{
    public class TestClassTwo
    {
        HiddenClass _hidden;

        public TestClassTwo()
        {
            _hidden = new HiddenClass();
            _hidden.HiddenValue = "test";

            TestClassThree three = new TestClassThree();
            three.Name = "test";
        }

        public string ValueTwo { get; set; }

        private class HiddenClass
        {
            public string HiddenValue { get; set; }
        }
    }
}
