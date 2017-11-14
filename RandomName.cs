using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12RockPaperScissors
{
    class RandomName : Player
    {
        Random rnd = new Random();
 
        public RandomName(string name = "random", int value = 0) : base(name, value)
        {
        }

        public override int generateRoshambo()
        {
            return rnd.Next(0, 3);
        }
    }
}
