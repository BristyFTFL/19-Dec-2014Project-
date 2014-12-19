using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationStackPractice4App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> students = new Stack<Student>();

            

            Student aStudent1 = new Student();
            aStudent1.regNo = "1234";
            aStudent1.firstName = "Karim";
            aStudent1.lastName = "Alam";

            Student aStudent2 = new Student();
            aStudent2.regNo = "1345";
            aStudent2.firstName = "Rahim";
            aStudent2.lastName = "Alam";

            Student aStudent3 = new Student();
            aStudent3.regNo = "5678";
            aStudent3.firstName = "Limon";
            aStudent3.lastName = "Hoq";

            students.Push(aStudent1);
            students.Push(aStudent2);
            students.Push(aStudent3);

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.regNo + " " + aStudent.GetFullName());
            }
            Console.ReadKey();

        }
    }
}
