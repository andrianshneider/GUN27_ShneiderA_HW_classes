using System;
namespace HW_classes
{
	public class Weapon
	{
		public float MinDamage { get; private set; }
		public float MaxDamage { get; private set; }
		
		public float damage;

        public string Name { get; }

        public Weapon(string argName)
		{
			Name = argName;
		}


        public Weapon(string argName, float argMinDamage, float argMaxDamage)
        {
            Name = argName;
			SetDamageParams(argMinDamage, argMaxDamage);
		}


        public void SetDamageParams(float argMinDamage, float argMaxDamage)
		{
			MinDamage = argMinDamage;
			MaxDamage = argMaxDamage;

			if (argMinDamage > argMaxDamage)
			{
				MinDamage = argMaxDamage;
				MaxDamage = argMinDamage;

				Console.WriteLine("Некорректные значения!");
			}

			if (argMinDamage < 1f)
			{
				MinDamage = 1f;
				Console.WriteLine("Форсированная установка значения миниального урона!");
			}

			if (argMaxDamage <= 1f)
			{
				MaxDamage = 10f;
				Console.WriteLine("Форсированная установка значения максимального урона!");
			}

			damage = GetDamage();
		}

		public float GetDamage()
		{
			return (MaxDamage + MinDamage) / 2;
		}
	}
}

