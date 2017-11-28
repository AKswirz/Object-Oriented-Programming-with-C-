using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theGoodGuy.Height);

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);

    }
}
        








        //try
        //{
        //    //firstWarrior.Age = 15;
        //    firstMage.Age = 25;
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //Console.WriteLine(fourthWarrior.HealthPoints);
        //Tools.ColorfulWriteLine(firstWarrior.ID.ToString(), ConsoleColor.DarkBlue);
        //Tools.ColorfulWriteLine(secondWarrior.ID.ToString(), ConsoleColor.Red);
        //Tools.ColorfulWriteLine(thirdWarrior.ID.ToString(), ConsoleColor.Green);

        //Warrior.GetDefaultValues(firstWarrior);
        //Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        //Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        //Warrior youngWarrior = new Warrior();

        //Console.WriteLine(youngWarrior.Age);

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

        //theGoodGuy.Greetings("Tod");

        //Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
//    }
//}