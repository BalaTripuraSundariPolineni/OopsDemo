using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            AbsDerivedClass abs = new AbsDerivedClass();
           Console.WriteLine( abs.GetFilePath());
            Console.WriteLine(abs.GetFileDetails());
            Console.ReadLine();
        }
    }
}
