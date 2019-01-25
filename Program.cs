using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCs
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab, made by Oleksandr Zhurbeliuk, IP-72");
            Student stud = new Student();
            stud.Name = "Oleksandr";
            stud.SecondName = "Zhurbeliuk";
            stud.BirthDate = new DateTime(1998, 12, 29);
            stud.StudentEducation = Student.Education.Bachelor;
            stud.Group = "IP-72";
            stud.NumOfRecordBook = 7211;
            Console.WriteLine("Student information");
            Console.WriteLine(stud+"\n");
            Console.WriteLine("Add exams");
            Examination[] exList = new Examination[4] {
                new Examination(1, "Object oriented programming", "Zhuk O. K.", 60, true, new DateTime(2018, 1, 18)),
                new Examination(1, "Mathematical analysis", "Mokruk I. V.", 88, false, new DateTime(2018, 1, 20)),
                new Examination(2, "Web Programming", "Rokol L. F.", 100, false, new DateTime(2018, 6, 18)),
                new Examination(2, "computer architecture", "Lol L, L.", 99, true, new DateTime(2018, 6, 22))
            };
            stud.AddExams(exList);
            Console.WriteLine(stud + "\n");
            stud.PrintFullInfo();
            Console.WriteLine("\n===========================================================");
            Console.WriteLine("Task number 1\n");
            Student stud2 = (Student)stud.Clone();
            stud.BirthYear = 2222;
            stud.Name = "Yan";
            Console.WriteLine("\nFirst student with changes");
            stud.PrintFullInfo();
            Console.WriteLine("\nClone of first student");
            stud2.PrintFullInfo();
            Console.WriteLine("\n===========================================================");
            Console.WriteLine("Task number 2");
            Console.WriteLine("Is first student equals to second? ");
            Console.WriteLine(stud.Equals(stud2));
            Student stud3 = (Student)stud.Clone();
            Console.WriteLine("Is first student equals to copy? ");
            Console.WriteLine(stud.Equals(stud3));
            Console.WriteLine("===========================================================");
            Console.WriteLine("Task number 6");
            Console.WriteLine("Result is less than 90:");
            foreach (Examination i in stud.GetTestsWithoutExams(90))
                Console.WriteLine(i);
            Console.WriteLine("\n===========================================================");
            Console.WriteLine("Task number 10");
            Examination[] sortedExams = stud.GetSorted();
            Console.WriteLine("Exams, that are sorted by subject:");
            foreach (Examination i in sortedExams)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
