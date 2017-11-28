using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        // fields ========================================================================================
        public static int id;

        private int height;
        private int weight;
        private int age;
        private string name;
        private Sword swordWeapon;

        // properties =====================================================================================
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Weight { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name}, is not a proper age for a Warrior. The age must be between 18 and 45.");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        // constructors =====================================================================================
        public Warrior()
            : this(170, 70)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, "Young Warrior")
        {
        }

        public Warrior(int height, int weight, string name)
        {
            this.Height = height;
            this.Weight = weight;
            this.Age = 18;
            this.Name = name;
            this.SwordWeapon = new Sword();
            Warrior.id++;
        }

        // methods ========================================================================================
        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }
}