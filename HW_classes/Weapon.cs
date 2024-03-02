using System;
namespace HW_classes
{
	public class Weapon
	{
		public float minDamage { get; private set; }
		public float maxDamage { get; private set; }
		private float buffer;
		public float damage;

        public string name { get; }

        public Weapon(string ArgName)
		{
			name = ArgName;
		}


		public Weapon(string ArgName, float ArgMinDamage, float ArgMaxDamage) : this(ArgName)
		{
			minDamage = ArgMinDamage;
			maxDamage = ArgMaxDamage;
		}

			
		public float SetDamageParams
		{
			set
			{
				if (minDamage > maxDamage)
				{
					buffer = minDamage;
					minDamage = maxDamage;
					maxDamage = buffer;

					Console.WriteLine("Некорректные значения!");
				}

				if (minDamage < 1f)
				{
					minDamage = 1f;
					Console.WriteLine("Форсированная установка значения миниального урона!");
				}

				if (maxDamage <= 1f)
				{
					maxDamage = 10f;
					Console.WriteLine("Форсированная установка значения максимального урона!");
				}
			}

		}

		public float GetDamage
		{
			get { return (maxDamage + minDamage) / 2; }
		}
	}
}

