using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDetails cd = new CustomerDetails();
            
           bool res = cd.GetCash("123475");
           bool res1 =  cd.GetCash(96325741);
           bool res2 = cd.GetCash(96325741, "123475");
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
