using System;
namespace HW_classes
{
	public class Weapon
	{
		public readonly string Name;
		public float MinDamage { get; private set; }
		public float MaxDamage { get; private set; }
		private float Buffer;

        public Weapon(string ArgName)
		{
            Name = ArgName;
        }


        public Weapon(string ArgName, float ArgMinDamage, float ArgMaxDamage) : this (ArgName)
		{
			MinDamage = ArgMinDamage;
			MaxDamage = ArgMaxDamage;

			public float SetDamageParams
			{
				set
				{
				if (MinDamage>MaxDamage)
				{
					MinDamage = 0;
				}
				}
			}
        }
    }
}

