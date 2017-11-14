using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12RockPaperScissors
{
    class FraggleRock : Player
    {
        public FraggleRock(String name = "Rock", int value = 0) : base(name, value)
        {
        } 

        public override int generateRoshambo()
        {
            return (int) Roshambo.Rock;
        }
    }
}
