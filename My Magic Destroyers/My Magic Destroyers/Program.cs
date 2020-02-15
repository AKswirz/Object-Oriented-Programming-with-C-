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
            Warlock secondWarlock = new Warlock("George II", 2);
            Warlock thirdWarlock = new Warlock("William III", 3, 99);

            Console.WriteLine(secondWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + secondWarlock.Id);
            Console.WriteLine(thirdWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + thirdWarlock.Id);
            Console.WriteLine(firstWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + firstWarlock.Id);
            Console.WriteLine(  );

            var text1 = firstWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + firstWarlock.Id;
            var text2 = secondWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + secondWarlock.Id;
            var text3 = thirdWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + thirdWarlock.Id;
            Tools.ColorfulWriteLine(text1, ConsoleColor.Red);
            Tools.ColorfulWriteLine(text2, ConsoleColor.Green);
            Tools.ColorfulWriteLine(text3, ConsoleColor.Yellow);



            Console.WriteLine(Environment.NewLine + firstWarlock.Name + "'s bodyarmor has " + firstWarlock.BodyArmor.ArmorPoints + " points. His sword can do " + firstWarlock.Weapon.Damage + " points of damage.");

            Warlock.GetDefaultValues();
        }
    }
}
