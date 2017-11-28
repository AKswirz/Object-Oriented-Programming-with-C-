using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Equipment.Weapons
{
    public class Axe
    {
        private int damage;

        public int Damage
        {
            get { return this.damage; }

            private set
            {
                if (value > 0 && value <= 10)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"A axe's damage value must be set between 1 and 10.");
                }
            }
        }


        public Axe()
        {

        }

        public void HackNSlash()
        {

        }
    }
}
