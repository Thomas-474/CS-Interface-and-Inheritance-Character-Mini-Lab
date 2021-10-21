using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    class Vendor : Character
    {
        public Vendor(string name, string race) : base(name, race)
        { }

        public override string Describe()
        {
            return $"Character: Vendor\nName: {Name}\nRace: {Race}";
        }
    }
}
