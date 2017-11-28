using Magic_Destroyers.Equipment.Armors;
using Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Melee
{
    public class Assassin
    {
        // fields ====================================================================================================
        private string name;
        private int level;
        private int healthPoints;
        private int fatigue;
        private int abilityPoints;
        private string faction;
        private Sword weapon;
        private LightLeatherVest bodyArmor;

        // properties ====================================================================================================
        public int AbilityPoints
        {
            get { return this.abilityPoints; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Ability points must be set between 1 and 100");
                }
            }
        }

        public string Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                if (value > 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    Console.WriteLine("You are dead.");
                }
            }
        }

        public int Fatigue
        {
            get { return this.fatigue; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.fatigue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Fatigue must be set between 1 and 100");
                }
            }
        }


        public int Level
        {
            get { return this.level; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Level must be set between 1 and 100");
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Sword Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public LightLeatherVest BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }


        // default constructor ====================================================================================================
        public Assassin()
            : this("Young Assassin", 1)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, 100)
        {
        }

        public Assassin(string name, int level, int healthPoints)
        {
            this.name = name;
            this.level = level;
            this.healthPoints = healthPoints;
            this.fatigue = 0;
            this.abilityPoints = 100;
            this.faction = "Melee";
            this.weapon = new Sword();
            this.bodyArmor = new LightLeatherVest();
        }


        // methods ====================================================================================================
        public void Raze()
        {

        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }
    }
}
