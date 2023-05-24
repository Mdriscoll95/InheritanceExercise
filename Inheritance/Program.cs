using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            bird myBird = new bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;



            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                habitat = "swamp",
                CanGrowTail = true
            };
            var myAnimals = new animal[] { myBird, lizard };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.isAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"it live by {animal.LandSeaAir}");
                Console.WriteLine($"it has {animal.LegCount} legs");
                Console.WriteLine($"");
            }




            
        }
    }
}
