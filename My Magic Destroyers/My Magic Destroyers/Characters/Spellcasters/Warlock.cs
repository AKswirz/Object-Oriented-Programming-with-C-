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
        private string name;
        private int level;
        private int healthPoints;
        private int abilityPoints;
        private string faction;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public Warlock()
            : this("Gene Ric", 1)
        {        
        }

        public Warlock(string name, int level)
            : this(name, level, 100)
        {
            this.name = name;
            this.level = level;
        }

        public Warlock(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 100;
            this.Faction = "SpellCaster";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
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

        public string Faction
        {
            get { return faction; }
            set
            {
                if (value.ToLower() == "melee" || value.ToLower() == "spellcaster")
                    faction = value;
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "The Faction is either Melee or SpellCaster.");
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
    }
}
