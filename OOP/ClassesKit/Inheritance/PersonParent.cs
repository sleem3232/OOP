using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.Inheritance
{
     class PersonParent
    {
        public string Name = "salim";
        public void print()
        {
            Console.WriteLine($" hi im here my name is {Name} ");
        }

    }
    class Son:PersonParent
    {
        public string SonName = "bob";

    }
}
