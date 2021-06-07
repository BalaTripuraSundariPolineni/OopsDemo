using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InOutSample inout= new InOutSample();
            inout.email = "develop@gmail";
            inout.id = 1201;

        }
    }
    public struct InOutSample
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

    }
}
