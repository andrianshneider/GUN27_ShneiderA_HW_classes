using System;
namespace HW_classes
{
	public class Unit
	{
		public readonly string Name;
		private readonly float Health;
		public float Damage;
        public float Armor;

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

