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

        }

    }
}
