using Non_Primitive_Types.Class;
using Non_Primitive_Types.Class.Math;

namespace Non_Primitive_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Naba";
            person.lastName = "modak";
            person.Introduce();

            Calculator cal = new Calculator();
            Console.WriteLine(cal.add(5, 7));
        }
    }
}