using System;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //   set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //  Datatypes and Input

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();


            Console.Write("Enter number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            double numberOfStudentsDouble = Convert.ToDouble(numberOfStudents);

            string[] namesArray = new string[numberOfStudents];

            int[] studentGrades = new int[numberOfStudents];

            double averageGrade;

            int teller = 1;

            double sum = 0;

            int index;

            int maxGrade;


            Console.WriteLine();
                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.Write($"Enter name of student {teller}: ");

                    namesArray[i] += Console.ReadLine();

                    teller++;
                }


            Console.WriteLine();
                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.Write($"Enter grade of {namesArray[i]}: ");

                    int grade = Convert.ToInt32(Console.ReadLine());

                    studentGrades[i] = grade;

                    sum += grade;
                }


            //  Convert
            Console.WriteLine();
                averageGrade = sum / numberOfStudentsDouble;
                Console.WriteLine($"Average grade: {averageGrade:0.0}");

                maxGrade = studentGrades.Max();
                index = Array.IndexOf(studentGrades, maxGrade);
            Console.WriteLine($"Student {namesArray[index]} has maximum grade: {maxGrade}");

            Console.WriteLine();
                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.WriteLine($"Grade for student {namesArray[i]} (course {courseName}): {studentGrades[i]}");
                }

            //  Output

            Console.ReadKey();
        }
    }
}
