using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no.of students to be validated");
            int noofTimes = Convert.ToInt32(Console.ReadLine());

            Student[] student = new Student[noofTimes];
            for(int cnt=0; cnt < noofTimes; cnt++)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Enter the Student Id");
                student[cnt] = new Student();
                student[cnt].sId = Convert.ToInt32(Console.ReadLine());

            }
        }
        public class Student
        {
           public int sId { get; set; }
            public string sName { get; set; }
            public int Lang1Mark { get; set; }
            public int Lang2Mark { get; set; }
            public int Maths { get; set; }
            public int Science { get; set; }
            public int Social { get; set; }
            public long TotalMarks { get; set; }
            public decimal Percentage { get; set; }
            public DateTime JoiningDate { get; set; }

        }
    }
}
