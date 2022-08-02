using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class PlayChoiceUC3
    {
        static int DiceNum;
        public static int position = 0;
        public static void setPosition()
        {
            Console.WriteLine("Starting game in Single Player Mode");
            Console.WriteLine("Starting at position " + position);
            rollsDie();
        }

        public static void rollsDie()
        {
            Random random = new Random();
            int choice = random.Next(3);
            if (choice == 0)
            {
                Console.WriteLine("No PLay");
                Console.WriteLine("Initial Position is " +position);
            }
            else if (choice == 1)
            {
                Console.WriteLine("Ladder is found");
                int DiceNum = random.Next(6);
                position += DiceNum;
                Console.WriteLine("Initial Position is " + position);
            }
            else
            {
                Console.WriteLine("Snake is found");
                int DiceNum = random.Next(6);
                position -= DiceNum;
                Console.WriteLine("Initial Position is " + position);
            }
        }
    }
}
