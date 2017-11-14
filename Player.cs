using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab12RockPaperScissors
{
    public enum Roshambo
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }

    abstract class Player
    {
        //TODO abstract class player
        //TODO store a name and roshambo value
        public Player(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
        
        public string Name { get; set; }

        public int Value { get; set; }

        public abstract int generateRoshambo();
    }
}
