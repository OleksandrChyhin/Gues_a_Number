using Gues_a_Number;

string gameMode;

while (true)
{
    Console.WriteLine("Start the game? (first press 1 or 2, then press enter):\n1. Start guessing game\n2. Exit");
     gameMode = Console.ReadLine();

    if (gameMode != "1" && gameMode != "2")
    {
        Console.WriteLine("Invalid input. Press any key to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (gameMode == "1")
    {
        Console.Clear();
        Console.WriteLine("You choose the guess mode. Have fun!\nPress any key to continue...");
        Console.ReadLine();
        Console.Clear();
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Good bye. Have fun!\nPress any key to continue...");
        Console.ReadLine();
        Console.Clear();
        break;
    }
}

switch (gameMode)
{
    case "1":

        GuessMode guessMode = new GuessMode();
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine($"You've got a {i} attempts");
            Console.WriteLine("Guess the number!");
            int.TryParse(Console.ReadLine(), out int tempGuess);
            if (guessMode.PlayerGuess(tempGuess) == true)
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
                Console.WriteLine($"The number is: {guessMode.GetNumber()}. Better luck next time!)");
            }
        }
        break;
    case "2":
        {

        }
        break;

}