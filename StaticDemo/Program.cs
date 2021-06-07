using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DashBoard dash = new DashBoard();
            dash.AddNumber();

            // SampleStaticobj = new SampleStatic();

            SampleStatic.FirstVariable = "Static sample";

            SampleStatic.empNumber = 3210;
            SampleStatic.empNumber = 3210;
            SampleStatic.empNumber = 3210;
            SampleStatic.empNumber = 3210;
            

            FooStatic firstObj = new FooStatic();
            //Normal way of calling
            firstObj.FirstVariable = "Abc123";
            firstObj.SecondVariable = "Abc123";
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, StaticVariable = {2}", firstObj.FirstVariable, firstObj.SecondVariable, FooStatic.StaticVariable);

            //Static way of calling property
            FooStatic.StaticVariable = "Static Data Changed";

            //Static way of calling Method
            FooStatic.StaticMethod();

            //Default Constructor will gets invoke if Constructor is not Specified in the class and assign the calssvaraibles with thier default Values
            FooStatic thirdObj = new FooStatic();
            Console.WriteLine("FirstVariable = {0},SecondVariable = {1}, Institute = {2}", thirdObj.FirstVariable, thirdObj.SecondVariable, FooStatic.StaticVariable);

            Console.ReadKey();
        }
    }



}
    }
}
