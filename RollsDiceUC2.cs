using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class RollsDiceUC2
    {
        public static int position = 0;
        public static void setPosition()
        {
            Console.WriteLine("Starting game in Single Player Mode");
            Console.WriteLine("Starting at position "+position);
            rollDie();
        }
        public static void rollDie()              //num - receives the rolling number limit
        {
            Random random = new Random();
            int DiceNum = random.Next(1,7);
            Console.WriteLine("Dice Number " +DiceNum);
            position += DiceNum;
            Console.WriteLine("Current Position is "+position);
        }
    }
}
