using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gues_a_Number
{
    public static class GuessMode
    {
        public static int TheNumber() => new Random().Next(0, 100);
        public static int theNumber = TheNumber(); 
        private static bool PlayerGuess(int playerGuess)
        {
            if (playerGuess == theNumber)
            {
                Console.WriteLine("Bull's eye!)");
                return true;
            }
            else if (playerGuess < theNumber)
            {
                Console.WriteLine("Guessed wrong.The number is bigger");
                return false;
            }
            else if (playerGuess > theNumber)
            {
                Console.WriteLine("Guessed wrong. The number is smaller");
                return false;
            }
            else
            {
                return false;
            }

        }
        public static void GameFeedback()
        {  
            for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"You've got {i} attempts");
            Console.WriteLine("Guess a number!");
            int.TryParse(Console.ReadLine(), out int tempGuess);
            if (GuessMode.PlayerGuess(tempGuess) == true)
            {
                Console.WriteLine("Game over");
                break;
            }
            else
            {
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            if (i - 1 == 0)
            {
                Console.WriteLine($"The number is: {theNumber}. Better luck next time!)");
            }
        }
        }
        
    }

}
