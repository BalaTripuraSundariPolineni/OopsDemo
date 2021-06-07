using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class FooStatic
    {
        private string firstVariable;

        public string FirstVariable { get; set; }

        public string SecondVariable
        {
            get; set;
        }
        public static string StaticVariable
        {
            get;
            set;
        }
        public FooStatic()
        {
            FirstVariable = string.Empty;
            SecondVariable = string.Empty;
        }
        //Static Constructor
        static FooStatic()
        {
            StaticVariable = "Initial Static Data";
        }

        public static string StaticMethod()
        {
            return string.Format("I am a Static Method i need to be called using My Class Name");
        }

    }
}
