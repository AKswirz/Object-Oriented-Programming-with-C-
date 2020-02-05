using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers.Characters
{
    public class Character
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        //private BodyArmor bodyArmor;
        //private Weapon weapon;

        public int AbilityPoints
        {
            get { return abilityPoints; }
            set { abilityPoints = value; }
        }

        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public int HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public LightLeatherVest BodyArmor
        //{
        //    get { return bodyArmor; }
        //    set { bodyArmor = value; }
        //}

        //public Sword Weapon
        //{
        //    get { return weapon; }
        //    set { weapon = value; }
        }

        //public BodyArmor bodyArmor { get; set; }
        //public Weapon weapon { get; set; }
    }
}
