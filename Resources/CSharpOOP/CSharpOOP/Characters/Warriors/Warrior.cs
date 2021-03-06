﻿using Enumuations;
using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        // fields ========================================================================================
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly int id;

        private static int idCounter;

        private int height;
        private int weight;
        private int age;
        private int healthPoints;
        private string name;
        private Faction faction;
        private Sword swordWeapon;

        // properties ====================================================================================
        public static int IdCounter
        {
            get
            {
                return Warrior.idCounter;
            }

            private set
            {
                Warrior.idCounter = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
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
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            private set
            {
                this.healthPoints = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
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
            : this(DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, DEFAULT_NAME, Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {
            Warrior.IdCounter++;
            this.id = Warrior.IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Age = DEFAULT_AGE;
            this.Name = name;
            this.Faction = faction;
            this.SwordWeapon = DEFAULT_WEAPON;

            if (this.Faction == Faction.GoodGuy)
            {
                this.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                this.HealthPoints = 100;
            }
        }

        // methods ========================================================================================
        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }

        public static void GetDefaultValues()
        {
            Console.WriteLine($"Default Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}");
        }
    }
}