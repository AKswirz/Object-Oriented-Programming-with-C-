using My_Magic_Destroyers.Enumerations;
using My_Magic_Destroyers.Equipment.Armors;
using My_Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers.Characters.Spellcasters
{
    public class Warlock
    {

        private static int idCounter;
        private readonly int id;      

        private string name;
        private int level;
        private int healthPoints;
        private int abilityPoints;
        //private string faction;
        private Faction faction;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        private const string DEFAULT_NAME = "Gene Ric";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_ABILITYPOINTS = 100;
        //private const string DEFAULT_FACTION = "SpellCaster";
        //private const Faction DEFAULT_FACTION = Faction.SpellCaster;
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();


        public Warlock()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {        
        }

        public Warlock(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
            this.name = name;
            this.level = level;      
        }

        public Warlock(string name, int level, int healthPoints)
            : this(name, level, healthPoints, Faction.Default)
        {
            this.name = name;
            this.level = level;
        }

        //public Warlock(string name, int level, int healthPoints, string faction)
        public Warlock(string name, int level, int healthPoints, Faction faction)
        {
            this.Name = name;
            this.Level = level;        
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            //this.Faction = faction;
            this.Faction = faction;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
            //if (this.Faction == "SpellCaster")
            if (this.Faction == Faction.Default)
            {
                this.HealthPoints = 50;
            }
            else
                this.HealthPoints = healthPoints;

            idCounter++;
            //this.Id = IdCounter;
            this.id = IdCounter;
        }

        public static int IdCounter
        {
            get { return Warlock.idCounter; }
            private set { idCounter = value; }
        }

        public int Id
        {
            get { return this.id; }
            //private set { this.id = value; }
        }

        public int AbilityPoints
        {
            get { return abilityPoints; }
            set
            {
                if (value >= 0)
                    abilityPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points cannot be less than 0.");
            }
        }

        //public string Faction
        //{
        //    get { return faction; }
        //    private set
        //    {
        //        this.faction = value;
        //    }
        //}
        
        public Faction Faction
        {
            get { return faction; }
            private set
            {
                this.faction = value;
            }
        }

        public int HealthPoints
        {
            get { return healthPoints; }
            set 
            {
                if (value >= 0 && value <= 100)
                    healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points must be between 0 and 100.");
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value > 0)
                    level = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "A characters Level cannot be less than 1.");
            }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        public Sword Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }



        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public static void GetDefaultValues()
        {
            Console.WriteLine(Environment.NewLine + $"The default variable values are:" + Environment.NewLine +
                $"=====================================" + Environment.NewLine +
                $"Default Name: {DEFAULT_NAME}" + Environment.NewLine +
                $"Default Level: {DEFAULT_LEVEL}" + Environment.NewLine +
                $"Default Healthpoints: {DEFAULT_HEALTHPOINTS}" + Environment.NewLine +
                $"Default Abilitypoints: {DEFAULT_ABILITYPOINTS}" + Environment.NewLine +
                //$"Default Faction: {DEFAULT_FACTION}" + Environment.NewLine +
                $"Default Height: {DEFAULT_HEIGHT}" + Environment.NewLine +
                $"Default Weight: {DEFAULT_WEIGHT}" + Environment.NewLine +
                $"Default Age: {DEFAULT_AGE}" + Environment.NewLine);
        }
    }
}
