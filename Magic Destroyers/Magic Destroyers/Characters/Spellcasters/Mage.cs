using Magic_Destroyers.Equipment.Armors;
using Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Mage
    {
        // fields ====================================================================================================
        private const string DEFAULT_NAME = "Young Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 75;
        private const int DEFAULT_FATIGUE = 10;
        private const int DEFAULT_ABILITYPOINTS = 50;

        private string name;
        private int level;
        private int healthPoints;
        private int fatigue;
        private int abilityPoints;
        private string faction;
        private Staff weapon;
        private ClothRobe bodyArmor;

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

        public Staff Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public ClothRobe BodyArmor
        {
            get { return this.bodyArmor; }
            set { this.bodyArmor = value; }
        }


        // default constructor ====================================================================================================
        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {

        }

        public Mage(string name, int level, int healthPoints)
        {
            this.name = name;
            this.level = level;
            this.healthPoints = healthPoints;
            this.fatigue = DEFAULT_FATIGUE;
            this.abilityPoints = DEFAULT_ABILITYPOINTS;
            this.faction = "Spellcasters";
            this.weapon = new Staff();
            this.bodyArmor = new ClothRobe();
        }


        // methods ============================================================================================================
        public void ArcaneWrath()
        {

        }

        public void Firewall()
        {

        }

        public void Meditation()
        {

        }
    }
}
