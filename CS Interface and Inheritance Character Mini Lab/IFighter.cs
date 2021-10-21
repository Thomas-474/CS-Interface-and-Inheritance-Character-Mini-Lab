using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    interface IFighter
    {
        string Name { get; }
        string Race { get; }
        string Weapon { get; }
    }
}
