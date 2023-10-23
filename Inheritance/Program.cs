using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("675638473");
            // car.MethodCar() -> methodcar is visible  


            // CASTING
            Vehicle v = car as Vehicle; // upcasting
            // only methodvehicle is visible

            Car? c = v as Car;   // downcasting same as (Car)v
            c?.MethodCar();     // null propagation syntax

            Console.WriteLine(c is Car);



            // BOXING & UNBOXING
            object o = 10; // boxing not upcasting as casting is generally something happens in context of reference type
            int x = (int)o; // unboxing not downcasting
        }
    }
}