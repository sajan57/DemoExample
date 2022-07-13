using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random class to generate the random number between the given range
            Random ram = new Random();

            int winNum = ram.Next(0, 50);
            bool win = false;

            do
            {
                
                    Console.WriteLine("Choose a number between 0 to 50:");
                    String s = Console.ReadLine();

                    int i = int.Parse(s);

                    if (i > winNum)
                    {
                        Console.WriteLine("Too High Number, Guess a Low number: ");
                    }

                    else if (i < winNum)
                    {
                        Console.WriteLine("Too Low number, Guess a higher Number");
                    }
                    else if (i == winNum)
                    {
                        Console.WriteLine("We all get the number at end:");
                        win = true;
                    }
                
            }
            while (win == false);
            {
                Console.WriteLine("press any number:");
                Console.WriteLine("Press enter to exist:");
                Console.ReadKey(true);
            }
        }
    }
}
