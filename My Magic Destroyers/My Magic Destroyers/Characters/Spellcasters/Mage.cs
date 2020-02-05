﻿using My_Magic_Destroyers.Equipment.Armors;
using My_Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe bodyArmor;
        private Staff weapon;

        public Mage()
        {
            
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

        public ClothRobe BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        public Staff Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
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