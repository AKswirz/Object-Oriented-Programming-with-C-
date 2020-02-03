using My_Magic_Destroyers.Equipment.Armors;
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
        public int abilityPoints { get; set; }
        public string faction { get; set; }
        public int healthPoints { get; set; }
        public int level { get; set; }
        public string name { get; set; }

        public ClothRobe bodyArmor { get; set; }
        public Staff weapon { get; set; }


        public Mage()
        {
            
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
