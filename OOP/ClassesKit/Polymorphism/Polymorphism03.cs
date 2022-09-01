using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.Polymorphism
{
     class Polymorphism03
    {

        public int ccc(int num1, int num2)
        {
            return num1 + num2 ;
           
        }
    }
    class Polymorphism04:Polymorphism03
    {
        public int ddd(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
