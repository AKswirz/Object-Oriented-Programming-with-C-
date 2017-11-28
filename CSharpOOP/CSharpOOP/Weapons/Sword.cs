namespace Weapons
{
    public class Sword
    {
        // fields ==================================================================
        private int damage;

        // properties ============================================================
        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                this.damage = value;
            }
        }

        // constructors =========================================================
        public Sword()
        {
            this.damage = 10;
        }

    }
}
