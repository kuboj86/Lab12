using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab12RockPaperScissors;

namespace RoshamboApp
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!\n");
                Console.Write("Enter your name?\t");
                string name = Console.ReadLine();
                Console.WriteLine("Wo do you want to play F/R");
                string opponent = Console.ReadLine();
                int.TryParse(opponent, out int choice);

                User user = new User(name, choice);

                Player opp = (opponent == "F") ? (Player)new FraggleRock() : new RandomName();

                //int rockValue = fraggleRock.generateRoshambo();
                //int randValue = randomName.generateRoshambo();
                int userValue = user.generateRoshambo();
                int opponentValue = opp.generateRoshambo();

                //int opponentValue = (opponent == "fraggle") ? fraggleRock.generateRoshambo() : randomName.generateRoshambo();

                Console.WriteLine($"{user.Name} picked {userValue} and opponent picked {opponentValue}");

                var win = userWins(userValue, opponentValue);
                if (win == null)
                {
                    Console.WriteLine("tie");
                }
                else if (win == true)
                {
                    Console.WriteLine("We win");
                }
                else
                {
                    Console.WriteLine("They win");
                }

            }

        }

        static Boolean? userWins(int userChoice, int oppententChoice)
        {
            if (userChoice == oppententChoice)
            {
                return null;
            }
            else if (userChoice == (int)Roshambo.Rock)
            {
                if (oppententChoice == (int)Roshambo.Scissors)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (userChoice == (int)Roshambo.Paper)
            {
                if (oppententChoice == (int)Roshambo.Scissors)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (oppententChoice == (int)Roshambo.Rock)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
