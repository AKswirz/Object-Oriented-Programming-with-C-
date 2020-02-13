using My_Magic_Destroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warlock warlock = new Warlock();

            Console.WriteLine(warlock.Name + "'s bodyarmor has " + warlock.BodyArmor.ArmorPoints + " points. His sword can do " + warlock.Weapon.Damage + " points of damage.");
        }
    }
}
