using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int res = num1 / num2;
                Console.WriteLine("the result is " + res);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Application completed");
            }
            Console.ReadLine();
        }
    }
}
