using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            int teller = 0;

            int occurenceTeller = 0;
            int[] numberArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter a number (0=stop): ");

                input = Convert.ToInt32(Console.ReadLine());

                numberArray[i] = input;

                teller++;

                if (input == 0)
                    break;
            }

            Console.WriteLine();
            Console.Write("Enter a searchvalue: ");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < teller; i++)
            {
                if (numberArray[i] == searchValue)
                {
                    occurenceTeller++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Number of occurences of searchvalue ({searchValue}) is: {occurenceTeller}");
            Console.ReadKey();
        }
    }
}
