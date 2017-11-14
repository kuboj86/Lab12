using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12RockPaperScissors
{
    class User : Player
    {
        public User(string name, int value) : base(name, value)
        {
        }

        public override int generateRoshambo()
        {
            return this.Value;
        }
    }
}
