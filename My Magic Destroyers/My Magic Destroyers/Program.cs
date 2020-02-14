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
            Warlock firstWarlock = new Warlock();
            Warlock secondWarlock = new Warlock("Second", 2);
            Warlock thirdWarlock = new Warlock("Third", 3, 99);

            Console.WriteLine(firstWarlock.Name + "'s bodyarmor has " + firstWarlock.BodyArmor.ArmorPoints + " points. His sword can do " + firstWarlock.Weapon.Damage + " points of damage.");
        }
    }
}
