using OOP.ClassesKit;
using OOP.ClassesKit.Abstract;
using OOP.ClassesKit.Access_Modifiers;
using OOP.ClassesKit.BasicClass;
using OOP.ClassesKit.Constructors;
using OOP.ClassesKit.Enum;
using OOP.ClassesKit.Get_and_Set;
using OOP.ClassesKit.Inheritance;
using OOP.ClassesKit.Interfaces;
using OOP.ClassesKit.Polymorphism;
using OOP.ClassesKit.PolymorphismOverriding;
using OOP.ClassesKit.PolymorphismPart2;
using System;

namespace OOP
{
    internal class Program
    {
     //   class Car {
          //  private string model = "Mustang";

            static void Main(string[] args)
            {
            ///<BasicClass> 
            /// Car myObj = new Car();
            ///  CarAttributes myObj2 = new CarAttributes()
            /// Console.WriteLine($"im {myObj2.Name} and my color is {myObj.color} and i have speed {myObj2.Speed}");
            /// Console.ReadKey();
            /// </BasicClass>


            ///<Constructors>
            /// Cars newcar = new Cars();
            /// Console.WriteLine($"i {newcar.name} and i {newcar.model} model and {newcar.description}");
            ///  </ Constructors >


            ///<private>
            /// Car myObj = new Car();
            ///Console.WriteLine(myObj.model);
            /// </private>

            ///<public>
            ///  PublicCar publicCar = new PublicCar();
            ///  Console.WriteLine(publicCar.model);
            ///  </ public >

            //}
            ///<GetandSet>
            ///  Person person = new Person();
            /// Console.WriteLine($"my name is {person.Name} and my age is {person.Age}");
            /// </GetandSet>
            /// 

            ///<Inheritance>
            ///Son personParent = new Son();
            ///Family family = new Family();
            /// Console.WriteLine($"my name is {personParent.Name} and my son is {personParent.SonName} and my family name is {family.family}");  
            /// </Inheritance>



            ///<PolymorphismPart1>
            ///Polymorphism01 myObj = new Polymorphism01();
            ///Polymorphism02 myObj2 = new Polymorphism02();
            ///Console.WriteLine(myObj.aaa(5,7));
            ///Console.WriteLine(myObj2.bbb(5,7));
            /// </PolymorphismPart1>

            ///<PolymorphismPart2>
            ///Home home = new Home();
            ///home2 home1 = new home2();
            ///home3 home2 = new home3();
            ///home.homemembers();
            ///home1.home2members();
            ///home2.home3members();
            ///Console.ReadLine(); 
            ///</PolymorphismPart2>

            ///<PolymorphismOverriding> 
            ///Vehicle vehicle = new Vehicle();
            ///Bus bus = new Bus();
            ///Motorcycle motorcycle = new Motorcycle();
            ///vehicle.VehicleSound();
            ///bus.VehicleSound();
            ///motorcycle.VehicleSound();
            ///</PolymorphismOverriding>


            ///<Abstract>
            /// Abstract 
            ///Why And When To Use Abstract Classes and Methods?
            ///To achieve security - 
            ///hide certain details
            ///and only show the important details of an object.
            ///Bus2 bus2 = new Bus2();
            ///bus2.VehicleSound();
            ///bus2.Sound();
            /// </Abstract>
            /// 

            /*Notes on Interfaces:
            Like abstract classes, interfaces cannot be used to create objects 
            Interface methods do not have a body - the body is provided by the "implement" class
            On implementation of an interface, you must override all of its methods
            Interfaces can contain properties and methods, but not fields/variables
            Interface members are by default abstract and public
            An interface cannot contain a constructor (as it cannot be used to create objects)*/
            ///<Interfaces> 
            ///VEHICLE vEHICLE =new VEHICLE();
            ///vEHICLE.myMethod();
            ///vEHICLE.myMethod2();
            ///vEHICLE.myMethod3();
            ///</Interfaces>



            /// ///<Enum>
            ///Use enums when you have values that you know aren't going to change,
            ///like month days, days, colors, deck of cards, etc.
            ///Level level = Level.red;
            ///Console.WriteLine(level);
            ///</Enum>
            ///

           




        }

       
    }
}
