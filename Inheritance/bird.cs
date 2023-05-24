using System;
namespace Inheritance
{
	public class bird : animal
	{
		public bird()
		{
			isAlive = true;
			LegCount = 2;
			LandSeaAir = "air";
			Age = 0;
		}
		public string WingColor { get; set; }
		public bool CanFly { get; set; }
		public bool WillMigrate { get; set; }
		public double BeakLength { get; set; }
	}
}

