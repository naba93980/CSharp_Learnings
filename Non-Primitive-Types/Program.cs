using Non_Primitive_Types.Class;
using Non_Primitive_Types.Class.Math;
using Non_Primitive_Types.Struct;


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

            Person2 person2 = new Person2(1, "Naba");
            Console.WriteLine(person2.Id);
            Console.WriteLine(person2.Name);

        }
    }
}