using System;
namespace HW_classes
{
	public class Unit
	{
		private float health;
		private float basedamage = 5;
        private float damage;
        private bool isWeaponEmpty = true;
        private float armor;
        private float helmArmor;
        private float shellArmor;
        private float bootsArmor;

        public string Name { get; }

        public float Health
		{
			get { return health; }
		}

        public Unit() : this("Unknown Unit")
        {

        }

        public Unit(string ArgName)
        {
            if (String.IsNullOrWhiteSpace(ArgName))
            {
                Name = ArgName;
            }
            else
            {
                Name = "Unknown Unit";
            }

        }

        public Unit(string ArgName, float ArgHealth)
        {
            if (String.IsNullOrWhiteSpace(ArgName))
            {
                Name = ArgName;
            }
            else
            {
                Name = "Unknown Unit";
            }

            health = ArgHealth;
        }

        public float Damage
        {
            get { return damage; }

            set
            {
                if (isWeaponEmpty)
                {
                    damage = basedamage;
                }
                else
                {
                    damage = basedamage+value;
                }
            }
        }

 
        public float Armor 
        {
            get { return (float)Math.Round(armor, 2); }

			set
			{
                if (value < 0)
                    armor = 0;
                else
                    armor = Math.Min(value, 1);
            }
        }

		public float RealHealth
		{
			get { return health*(1f+Armor); }
		}

		public bool SetDamage
		{
			get 
			{
				if (health<=0f)
				{ return true; }
				else
				{ return false; } 
			}
			set
			{
				health = health - Convert.ToInt16(value) * Armor;
			}
		}

        public void EquipWeapon(float argMinDamage, float argMaxDamage)
        {
            var currentWeapon = new HW_classes.Weapon("Weapon", argMinDamage, argMaxDamage);
            isWeaponEmpty = false;
            Damage = currentWeapon.damage;
        }

        public void EquipHelm(string argName, float argArmor)
        {
            var currentHelm = new HW_classes.Helm(argName, argArmor);
            helmArmor = currentHelm.Armor;
            Armor = helmArmor + shellArmor + bootsArmor;
        }

        public void EquipShell(string argName, float argArmor)
        {
            var currentShell = new HW_classes.Shell(argName, argArmor);
            shellArmor = currentShell.Armor;
            Armor = helmArmor + shellArmor + bootsArmor;
        }

        public void EquipBoots(string argName, float argArmor)
        {
            var currentBoots = new HW_classes.Boots(argName, argArmor);
            bootsArmor = currentBoots.Armor;
            Armor = helmArmor + shellArmor + bootsArmor;
        }

        				
	}
}

