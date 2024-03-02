using System;
namespace HW_classes
{
	public class Unit
	{
		private float health;
		private float basedamage = 5;
		private string currentWeapon;
        private string currentHelm;
        private string currentShell;
        private string currentBoots;

        public string Name { get; }

        public float Health
		{
			get { return health; }
		}

        public float Damage (Weapon weapon)
        {
			if (String.IsNullOrEmpty(weapon.name))
			{
                return basedamage;
            }
			else
			{
                return basedamage + weapon.damage;
            }
		}

		private float GetArmor()
		{
            var Helm = new HW_classes.Helm();
            var Shell = new HW_classes.Shell();
            var Boots = new HW_classes.Boots();
			return Helm.armor + Shell.armor + Boots.armor;
		}


        public float Armor 
        {
			get { return GetArmor(); }
			set
			{
				if (value < 0)
					value = 0;
				else
					value = Math.Min(value, 1);
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

		public void EquipWeapon(Weapon weapon1)
		{
			currentWeapon = weapon1.name;
		}

        public void EquipHelm(Helm helm)
        {
            currentHelm = helm.name;
        }

        public void EquipShell(Shell shell)
        {
            currentShell = shell.name;
        }

        public void EquipBoots(Boots boots)
        {
            currentBoots = boots.name;
        }

        public Unit(): this("Unknown Unit")
		{

		}

		public Unit(string ArgName)
		{
			if (ArgName != "")
			{
				Name = ArgName;
			}
			else
			{
				Name = "Unknown Unit";
			}
						
        }

	}
}

