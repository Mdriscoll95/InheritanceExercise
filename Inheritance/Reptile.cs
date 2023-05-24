using System;
namespace Inheritance
{
	public class Reptile : animal
	{
		public Reptile()
		{
            isAlive = true;
            LegCount = 4;
            LandSeaAir = "land";
            Age = 0;
        }
		public bool IsColdBlooded { get; set; }
		public bool IsScaly { get; set; }
		public string habitat { get; set; }
		public bool CanGrowTail { get; set; }

		
			
	}
}

