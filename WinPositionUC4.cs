using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class WinPositionUC4
    {
        public static int position = 0;
        public static void setPosition()
        {
            Console.WriteLine("Starting game in Single Player Mode");
            Console.WriteLine("Starting at position " + position);
            rollsDie();
        }
        public static void rollsDie()
        {
            while(position < 100)
            {
                Random random = new Random();
                int choice = random.Next(3);
                if (choice == 0)                          //No Play
                {
                    Console.WriteLine("No PLay");
                    Console.WriteLine("Initial Position is " + position);
                }
                else if (choice == 1)                      //Ladder found
                {
                    Console.WriteLine("Ladder is found");
                    int DiceNum = random.Next(6);
                    position += DiceNum;
                    Console.WriteLine("Initial Position is " + position);
                }
                else                                        //Snake found
                {
                    Console.WriteLine("Snake is found");
                    int DiceNum = random.Next(6);
                    position -= DiceNum;
                    Console.WriteLine("Initial Position is " + position);
                }
                //in case position lessthan 0, position will be set to 0
                if (position < 0)
                {
                    position = 0;
                }
                //In case Player reaches the end.
                if (position == 100)
                {
                    Console.WriteLine("Wou Win");
                    break;
                }
            }
        }
    }
}
