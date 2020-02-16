using My_Magic_Destroyers.Characters.Spellcasters;
using My_Magic_Destroyers.Enumerations;
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
            //Warlock fourthWarlock = new Warlock("Henry IV", 4, 95, "Melee");
            Warlock fourthWarlock = new Warlock("Henry IV", 4, 95, Faction.Melee);

            var text = string.Format($"Name is {0} and I belong to the {1} faction. There are {2} warlocks, my ID # is {3}");
            var text1 = string.Format("Name is {0} belonging to the {1} faction. There are {2} warlocks, ID # is {3} and health is a {4}.", firstWarlock.Name, firstWarlock.Faction, Warlock.IdCounter, firstWarlock.Id, firstWarlock.HealthPoints);
            //var text1 = firstWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + firstWarlock.Id;
            var text2 = secondWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + secondWarlock.Id;
            var text3 = thirdWarlock.Name + ", there are " + Warlock.IdCounter + " warlocks and I have ID# " + thirdWarlock.Id;
            var text4 = string.Format("Name is {0} belonging to the {1} faction. There are {2} warlocks, ID # is {3} and health is a {4}.", fourthWarlock.Name, fourthWarlock.Faction, Warlock.IdCounter, fourthWarlock.Id, fourthWarlock.HealthPoints);

            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text1);
            Console.WriteLine(text4);
            Console.WriteLine();

            Tools.ColorfulWriteLine(text1, ConsoleColor.Red);
            Tools.ColorfulWriteLine(text2, ConsoleColor.Green);
            Tools.ColorfulWriteLine(text3, ConsoleColor.Yellow);
            Tools.ColorfulWriteLine(text4, ConsoleColor.Cyan);

            Console.WriteLine(Environment.NewLine + firstWarlock.Name + "'s bodyarmor has " + firstWarlock.BodyArmor.ArmorPoints + " points. His sword can do " + firstWarlock.Weapon.Damage + " points of damage.");

            Warlock.GetDefaultValues();
        }
    }
}
