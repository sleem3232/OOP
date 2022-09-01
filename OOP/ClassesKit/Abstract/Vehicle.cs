using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.Abstract
{
    // Abstract class

    abstract class Vehicle
    {
        // Abstract method (does not have a body)
        public abstract void VehicleSound();
        public void Sound()
        {
            Console.WriteLine("all the Vehicles have sound");
        }
    }
    class Bus2 : Vehicle
    {
        public override void VehicleSound()
        {
            Console.WriteLine("beeb beeb");
        }
    }
}
