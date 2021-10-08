using System;
using System.Globalization;
using System.Threading;

namespace PPweek5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            //  Datatypes
            Random random = new Random();

            double randomNumber;

            double[] randomNumberArray = new double[20];

            double sum = 0;

            double average;

            double difference;


            //  Convert
            for (int i = 0; i < 20; i++)
            {
                randomNumber = random.Next(0, 200);

                sum += randomNumber;

                randomNumberArray[i] += randomNumber;

                Console.WriteLine($"Element {i} is {randomNumber}");
            }

            average = sum / 20;


            //  Output
            Console.WriteLine();

            Console.WriteLine($"{average}");

            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                difference = Math.Abs(randomNumberArray[i] - average);

                Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
            }
            Console.ReadKey();
        }
    }
}
