using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6GC
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino!");
            bool UserContinue = true;
            while (UserContinue == true)
            {

                Console.WriteLine("Roll the dice? y/n");
                string start = Console.ReadLine();
                if (start.ToLower() == "no" || start.ToLower() == "n")
                {
                    UserContinue = false;
                    continue;
                }


                Console.WriteLine("Enter number of sides of your dice ");
                int sides = (int.Parse(Console.ReadLine()));

                Console.WriteLine((RandomDie(sides)));
                Console.WriteLine((RandomDie(sides)));

                Console.WriteLine("Do you want to play gain? y/n?");
                string play = Console.ReadLine();

                if (play.ToLower() == "no" || play.ToLower() == "n")
                {
                    UserContinue = false;
                }

                }


            }


        public static int RandomDie(int max)
        {
            //int roll;
            Random random = new Random();

            int dice = random.Next(1, max + 1);
            //return dice;

            return dice;
        }
    }
}
