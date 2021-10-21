using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_and_Inheritance_Character_Mini_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Player link = new Player("Link", "Hylian", "Sword");
            Console.WriteLine(link.Describe());

            Console.WriteLine("");

            Enemy moblinArcher = new Enemy("Moblin Archer", "Moblin", "Bow & Arrows");
            Console.WriteLine(moblinArcher.Describe());

            Console.WriteLine("");

            Vendor beedle = new Vendor("Beedle", "Hylian");
            Console.WriteLine(beedle.Describe());

            Console.ReadKey();
        }
    }
}
