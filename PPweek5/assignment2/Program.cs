using System;
using System.Linq;


namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Datatypes
            int[] randomNumberArray = new int[20];
            Random random = new Random();
            int lowestFrequenty = 0;
            int randomNumber;
            

            //  Input
            for (int i = 0; i < 20; i++)
            {
                randomNumber = random.Next(0, 149);

                randomNumberArray[i] += randomNumber;

                Console.WriteLine($"Element {i} = {randomNumber}");
            }


            //  Convert
            int lowestNumber = randomNumberArray.Min();

            for (int i = 0; i < 20; i++)
            {
                if(lowestNumber == randomNumberArray[i])
                {
                    lowestFrequenty++;
                }
            }


            //  Output
            Console.WriteLine();

            Console.WriteLine($"smallest number = {lowestNumber}");

            Console.WriteLine($"number of occurence = {lowestFrequenty}");

            Console.ReadKey();
        }
    }
}
