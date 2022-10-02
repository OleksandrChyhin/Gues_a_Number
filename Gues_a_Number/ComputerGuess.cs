using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gues_a_Number
{
    public static class ComputerGuess
    {
        public static bool ComputerFeedback()
        {
            int lowerBound = 0;
            int upperBound = 100;
            int middle = upperBound / 2;
            for (int i = 5; i > 0; i--)
            {
                int computerGuess = middle;
                int tempRand = 0;
                Console.WriteLine($"I have {i} attempts");
                tempRand = new Random().Next(lowerBound, upperBound);
                if (i - 1 == 0)
                {
                    while (true)
                    {
                        Console.WriteLine($"The number is: {tempRand}. Am I right? Press \"1\" if the number is correct, \"2\" if it is wrong");

                        int.TryParse(Console.ReadLine(), out int userFeedback1);
                        if (userFeedback1 == 1)
                        {
                            Console.WriteLine($"Thank you for the game!");
                            Console.ReadLine();
                            Console.Clear();
                            return true;
                        }
                        if (userFeedback1 == 2)
                        {
                            Console.WriteLine($"Better luck next time!");
                            Console.ReadLine();
                            Console.Clear();
                            return true;
                        }
                        else
                        {
                            Console.ReadLine();
                            Console.WriteLine("Invalid input. Press enter and try again");
                            Console.Clear();
                        }

                    }
                }
                Console.WriteLine($"The number is: {computerGuess}. Am I right? Press \"1\" if the number is correct, \"2\" if the number is bigger or \"3\" if the number is smaller");
                int.TryParse(Console.ReadLine(), out int userFeedback);
                Console.Clear();
                while (true)
                {

                    Console.WriteLine($"The number is: {computerGuess}. Am I right? Press \"1\" if the number is correct, \"2\" if the number is bigger or \"3\" if the number is smaller");
                    if (userFeedback == 1)
                    {
                        Console.WriteLine($"Thank you for the game!");
                        Console.ReadLine();
                        Console.Clear();
                        return true;
                    }
                    else if (userFeedback == 2)
                    {
                        lowerBound = computerGuess;
                        middle += (upperBound - lowerBound) / 2;
                        Console.Clear();
                        break;
                    }
                    else if (userFeedback == 3)
                    {
                        upperBound = computerGuess;
                        middle -= (upperBound - lowerBound) / 2;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.ReadLine();
                        Console.WriteLine("Invalid input. Press enter and try again");
                        Console.Clear();
                    }

                }
                if (i - 1 == 0)
                {
                    Console.WriteLine($"I lose. Better luck next time!)");
                }
            }
            return false;
        }
    }
}
