using System;

namespace SnakeAndLadderProblem101
{
    class SnakeAndLadderSinglePlayer
    {
        public SnakeAndLadderSinglePlayer()
        {
            Console.WriteLine("For Single Player");
            int position = 0;
            int diceRolls = 0;

            while (position < 100)
            {
                Console.WriteLine("Current position: " + position);
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();

                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                diceRolls++; // Increment dice roll counter

                if (position + diceRoll <= 100)
                {
                    int newPosition = position + diceRoll;

                    int option = random.Next(0, 3);

                    if (option == 1) // Ladder
                    {
                        newPosition += diceRoll;
                        Console.WriteLine("Dice rolled: " + diceRoll);
                        Console.WriteLine("Congratulations! You climbed a ladder and moved forward by " + diceRoll + " steps. \nNow you are at " + newPosition);
                    }
                    else if (option == 2) // Snake
                    {
                        newPosition -= diceRoll;
                        Console.WriteLine("Dice rolled: " + diceRoll);
                        Console.WriteLine("Oh no! You got bitten by a snake and moved backward by " + diceRoll + " steps.");
                        Console.WriteLine("Now you are at " + newPosition);
                    }
                    else // No Play
                    {
                        Console.WriteLine("No Play! Stay at the same position.");
                    }

                    if (newPosition <= 100)
                        position = newPosition;

                    Console.WriteLine("Dice rolls: " + diceRolls);
                    Console.WriteLine("Current position: " + position);
                }
                else
                {
                    Console.WriteLine("Oops! Your Dice Roll is more than needed. Try again!");
                }
            }

            Console.WriteLine("Congratulations! You reached position 100 and won the game!");
            Console.WriteLine("Total dice rolls: " + diceRolls);
            Console.ReadKey();
        }
    }
}


