using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.PolymorphismOverriding
{
     class Vehicle
    {
        public virtual  void VehicleSound()
        {
            Console.WriteLine("all the Vehicle have sound");
        }
    }
    class Bus:Vehicle
    {
        public override void VehicleSound()
        {
            Console.WriteLine("beeb beeb");
        }
    }
    class Motorcycle:Vehicle
    {
        public override void VehicleSound()
        {
            Console.WriteLine("toot toot");
        }
    }
}
