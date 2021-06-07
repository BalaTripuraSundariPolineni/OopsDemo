using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class SampleStatic
    {
        public static int empNumber = 0;
        public static string FirstVariable { get; set; }

        public static string SecondVariable
        {
            get; set;
        }

        public static string StaticVariable
        {
            get;
            set;
        }

        public static string StaticMethod()
        {
            return string.Format("I am a Static Method i need to be called using My Class Name");
        }
    }

}

