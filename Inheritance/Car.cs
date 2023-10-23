namespace Inheritance
{
    public class Car : Vehicle
    {
        public void MethodCar()
        {
            Console.WriteLine("Method in car");
        }
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car vehicle {0}", registrationNumber);
        }
    }
}