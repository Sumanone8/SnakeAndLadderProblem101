using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem101
{
    class SnakeAndLadderSinglePlayer
    {
        public SnakeAndLadderSinglePlayer()
        {
            Console.WriteLine("For Single Player");
            int position = 0;
            Console.WriteLine("Current position: " + position);
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();

            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice rolled: " + diceRoll);

            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play! You stay at the current position.");
                    break;
                case 1:
                    int ladderSteps = random.Next(1, 7);
                    Console.WriteLine("Congratulations! You climbed a ladder and move forward by " + ladderSteps + " steps.");
                    position += ladderSteps;
                    break;
                case 2:
                    int snakeSteps = random.Next(1, 7);
                    Console.WriteLine("Oh no! You got bitten by a snake and move backward by " + snakeSteps + " steps.");
                    position -= snakeSteps;
                    break;
            }

            // Check if the position is negative
            if (position < 0)
                position = 0;

        }

    }
}
