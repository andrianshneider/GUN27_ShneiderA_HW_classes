using System;
namespace HW_classes
{
	public class Unit
	{
		public readonly string Name;
		//private readonly float Health;
		public float Damage;
		public float Armor;

        //      public float Health
        //      {
        //          get { return Health; }
        //      }

        //      public float RealHealth
        //{
        //	get { return Health; }
        //	set
        //	{
        //		value = Health * (1f+Armor);
        //	}
        //}

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

			var Helm = new HW_classes.Helm();
			var Shell = new HW_classes.Shell();
            var Boots = new HW_classes.Boots();
            
			Armor = Math.Min(Helm.Armor + Shell.Armor + Boots.Armor, 1);
		}
	}
}

