using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Equipment.Armors
{
    public class ClothRobe
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
                    Console.WriteLine("Someone is fighting buck naked!");
                }
            }
        }

        public ClothRobe()
        {

        }
    }
}
