using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers.Equipment.Weapons
{
    public class Sword
    {
        private int damage;
        private const int DEFAULT_DAMAGE = 10;

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                    throw new ArgumentOutOfRangeException(string.Empty, "The Damage must be greater than 0.");
            }
        }

        public Sword()
        {
            this.Damage = DEFAULT_DAMAGE;
        }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
