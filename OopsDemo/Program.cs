using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Program
    {
        public Program()
        {
            
        }
        static void Main(string[] args)
        {
            //Date and Time
            DateTime dt = System.DateTime.Now;
            dt = System.DateTime.Now;
            Console.WriteLine("Date and Time :" + dt);

            //No.of students report
            Student student = new Student();
           
            Console.WriteLine("Enter no.of students you want to validate");
            int noofTimes = Convert.ToInt32(Console.ReadLine());

            //creation of array
            Student[] students = new Student[noofTimes];
            for(int cnt = 0 ; cnt < noofTimes ; cnt++)
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Enter Student Id");
                students[cnt] = new Student();
                students[cnt].studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                students[cnt].studentName = Console.ReadLine();
                Console.WriteLine("Enter Student Mark");
                students[cnt].Lang1Mark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Mark");
                students[cnt].Lang2Mark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Mark");
                students[cnt].Maths = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Mark");
                students[cnt].Science = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Mark");
                students[cnt].Social = Convert.ToInt32(Console.ReadLine());

            }
            Student.CalculateMarks(students);
            for (int cnt = 0; cnt < students.Length; cnt++)
            {
                Console.WriteLine(students[cnt].TotalMark);
                Console.ReadLine();
            }
        
        }

        //creation of class
        public class Student
        {
            public int studentId { get; set; }

            public string studentName { get; set; }

            public int Lang1Mark { get; set; }
            public int Lang2Mark { get; set; }
            public int Maths { get; set; }
            public int Science { get; set; }
            public int Social { get; set; }
            public long TotalMark { get; set; }
            public decimal Percentage { get; set; }
            public DateTime joiningdate {get;set;}


            public static void CalculateMarks(Student[] students)
            {
                for (int cnt = 0; cnt < students.Length; cnt++)
                {
                    int mark1 = students[cnt].Maths;
                    int mark2 = students[cnt].Science;
                    int mark3 = students[cnt].Social;

                    students[cnt].TotalMark = mark1 + mark2 + mark3;
                    long total = students[cnt].TotalMark;
                    
                    
                }
                
            }
            public  void CalculatePercentage(long total)
            {
                decimal Percentage = total / 5;
                Console.WriteLine("percentage af student is :" + Percentage);
                Console.ReadLine();
            }

        }
    }
}
