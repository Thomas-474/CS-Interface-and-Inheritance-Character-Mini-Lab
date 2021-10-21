using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    abstract class Character
    {
        public string Name
        { get; protected set; }

        public string Race
        { get; protected set; }

        public Character(string name, string race)
        {
            Name = name;
            Race = race;
        }

        public abstract string Describe();
    }
}
