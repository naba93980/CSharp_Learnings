namespace Inheritance
{
    public class Vehicle
    {
        private readonly string? _registrationNumber;

        public void MethodVehicle()
        {
            Console.WriteLine("Method in vehicle");
        }

        public Vehicle(string registrationNumber) {
            this._registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle init {0}", _registrationNumber);

        }
    }
}