using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gues_a_Number
{
    public class GuessMode
    {
        private int theNumber = new Random().Next(0, 100);

        public bool PlayerGuess(int playerGuess)
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
        public int GetNumber() => theNumber;
    }

}
