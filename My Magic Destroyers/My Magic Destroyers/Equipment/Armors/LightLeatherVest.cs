using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magic_Destroyers.Equipment.Armors
{
    public class LightLeatherVest
    {
		private int armorPoints;

		public int ArmorPoints
		{
			get { return armorPoints; }
			set
			{
				if (value >= 1)
				{
					armorPoints = value;
				}
				else
					throw new ArgumentOutOfRangeException(string.Empty, "The Armor Points must be greater than 0.");
			}
		}

		public LightLeatherVest()
		{
			this.armorPoints = 20;
		}
	}
}
