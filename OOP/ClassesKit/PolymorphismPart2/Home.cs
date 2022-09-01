using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ClassesKit.PolymorphismPart2
{
    
   public  class Home
    {
        public void homemembers()
        {
            Console.WriteLine("we are 5 in family");
            
        }
    }
  public  class home2:Home
    {
        public void home2members()
        {
            Console.WriteLine("we are 3 in family");
        }
    }
    public class home3 : Home
    {
        home2 home2=new home2();
        Home home=new Home();
        public void home3members()
        {
          
            home2.home2members();
            home.homemembers();
           
            
        }
    }


}
