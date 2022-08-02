using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class TimesDieRolledUC6
    {
        static int DiceNum;
        public static int position = 0;
        static int count = 0;
        public static void setPosition()
        {
            Console.WriteLine("Starting game in Single Player Mode");
            Console.WriteLine("Starting at position " + position);
            rollsDie();
        }
        public static void rollsDie()
        {
            Random random = new Random();
            while (position < 100)
            {
                ++count;
                int choice = random.Next(3);
                if (choice == 0)                          //No Play
                {
                    Console.WriteLine("No PLay");
                    Console.WriteLine("Initial Position is " + position);
                }
                else if (choice == 1)                      //Ladder found
                {
                    Console.WriteLine("Ladder is found");
                    DiceNum = random.Next(6);
                    position += DiceNum;
                    Console.WriteLine("Initial Position is " + position);
                }
                else                                        //Snake found
                {
                    Console.WriteLine("Snake is found");
                    DiceNum = random.Next(6);
                    position -= DiceNum;
                    Console.WriteLine("Initial Position is " + position);
                }
                //in case position lessthan 0, position will be set to 0
                if (position < 0)
                {
                    position = 0;
                }
                //in case position greaterthan 100, then position will be set back to its previous position
                if (position > 100)
                {
                    position -= DiceNum;
                }
                //In case Player reaches the end.
                if (position == 100)
                {
                    Console.WriteLine("Wou Win");
                    Console.WriteLine("No. of times Dice rolled = " + count);
                    break;
                }
                Console.WriteLine("Current Position "+position);
            }
        }
    }
}
