using Characters.Warriors;
using CSharpOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();        
        Console.WriteLine("Counter: " + Warrior.IdCounter);

        Warrior secondWarrior = new Warrior(185, 93);
        Console.WriteLine("Counter: " + Warrior.IdCounter);

        Warrior thirdWarrior = new Warrior(195, 100, "Third Warrior");
        Console.WriteLine("Counter: " + Warrior.IdCounter);


        Tools.ColorfulWriteLine("ID: " + firstWarrior.ID.ToString(), ConsoleColor.Cyan);
        Tools.ColorfulWriteLine("ID: " + secondWarrior.ID.ToString(), ConsoleColor.Red);
        Tools.ColorfulWriteLine("ID: " + thirdWarrior.ID.ToString(), ConsoleColor.Yellow);

        Console.WriteLine(thirdWarrior.Name);

        Warrior.GetDefaultValues();

        //Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");

        //Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        //Console.WriteLine(theBadGuy.Height);
        //Console.WriteLine(theGoodGuy.Height);

        //try
        //{
        //    theGoodGuy.Age = 25;
        //    theBadGuy.Age = 15;
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}        

        //Console.WriteLine(theGoodGuy.Age);
        //Console.WriteLine(theBadGuy.Age);

        //theGoodGuy.Greetings(theBadGuy);
        //theBadGuy.Greetings(theGoodGuy);

        //Console.WriteLine( "The Good Guy will do " + theGoodGuy.SwordWeapon.Damage + " damage."); 

        Console.ReadLine();
    }
}

