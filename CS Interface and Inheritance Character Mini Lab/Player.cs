using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    class Player : Character, IFighter
    {
        public string Weapon
        { get; }

        public Player(string name, string race, string weapon) : base(name, race)
        {
            Weapon = weapon;
        }

        public override string Describe()
        {
            return $"Character: Player\nName: {Name}\nRace: {Race}\nWeapon: {Weapon}";
        }
    }
}
