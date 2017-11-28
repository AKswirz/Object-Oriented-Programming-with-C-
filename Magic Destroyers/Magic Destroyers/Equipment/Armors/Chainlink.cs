using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Equipment.Armors
{
    public class Chainlink
    {
        private int armorPoints;
        
        public int ArmorPoints
        {
            get { return this.armorPoints; }
            set
            {
                if (value > 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Armor points must be greater than 0");
                }
            }
        }

        public Chainlink()
        {

        }
    }
}
