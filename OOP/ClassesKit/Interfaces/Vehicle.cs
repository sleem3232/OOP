using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.Interfaces
{
    interface Vehicle
    {
        void myMethod(); // interface method
    }
    interface Vehicle2
    {
        void myMethod2();
    }
    interface Vehicle3
    {
        void myMethod3();
    }

    class VEHICLE : Vehicle, Vehicle2, Vehicle3
    {
        public void myMethod()
        {
            Console.WriteLine("im the first Vechile");
        }
        public void myMethod2()
        {
            Console.WriteLine("im the second Vechile");

        }
        public void myMethod3()
        {
            Console.WriteLine("im the therd Vechile");

        }

    }
}
