using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    class Enemy : Character, IFighter
    {
        public string Weapon
        { get; }

        public Enemy(string name, string race, string weapon) : base(name, race)
        {
            Weapon = weapon;
        }

        public override string Describe()
        {
            return $"Character: Enemy\nName: {Name}\nRace: {Race}\nWeapon: {Weapon}";
        }
    }
}
