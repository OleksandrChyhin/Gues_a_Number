using Gues_a_Number;
while (true)
{
    string gameMode;
    while (true)
    {
        
        Console.WriteLine("Start the game? (first press 1 or 2, then press enter):\n1. Start guessing game\n2. Try to confuse your PC");
        gameMode = Console.ReadLine();

        if (gameMode != "1" && gameMode != "2")
        {
            Console.WriteLine("Invalid input. Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        else if (gameMode == "1")
        {
            Console.Clear();
            Console.WriteLine("You choose the guess mode. Have fun!\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Show this machine who is the Boss!\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
            break;
        }
    }

    switch (gameMode)
    {
        case "1":
            GuessMode.theNumber = GuessMode.TheNumber();
            GuessMode.GameFeedback();

            break;
        case "2":
            {
                Console.WriteLine("Let's try to confuse this pc!\n Сhoose a number and your pc will try to guess it\n Press enter to continue...");
                ;
                Console.Clear();
                ComputerGuess.ComputerFeedback();

            }
            break;

    }
    Console.WriteLine("Do you want to play again? (first press 1 or 2, then press enter):\n1. Play again\n2. Exit");
    string restart;
    restart = Console.ReadLine();

    if (restart != "1" && restart != "2")
    {
        Console.WriteLine("Invalid input. Press enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (restart == "1")
    {
        Console.Clear();
        Console.WriteLine("Restarting game... Have fun!\nPress enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Good Bye!");
        Console.ReadLine();
        Console.Clear();
        break;

    }
}
