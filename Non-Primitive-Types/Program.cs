using Non_Primitive_Types.Class;
using Non_Primitive_Types.Class.Math;
using Non_Primitive_Types.Enums;
using Non_Primitive_Types.Struct;


namespace Non_Primitive_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            // Class
            Person person = new Person();
            person.firstName = "Naba";
            person.lastName = "modak";
            person.Introduce();

            Calculator cal = new Calculator();
            Console.WriteLine(cal.add(5, 7));

            // Struct
            Person2 person2 = new Person2(1, "Naba");
            Console.WriteLine(person2.Id);
            Console.WriteLine(person2.Name);

            // Enum
            Databases server = Databases.SQLSERVER;                  // every enum constant here is an instance of the Database enum class which inherits Enum class
            Console.WriteLine(server.ToString());                                // calls server.ToString() automatically
            Console.WriteLine(server.GetHashCode());
            Console.WriteLine((int)server);

            Console.WriteLine(server.GetType());                                // Databases -> Enums -> ValueType -> Object

            Object v = Enum.Parse(typeof (Databases), "MYSQL");   // Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
            Console.WriteLine((Databases)15);
            Console.WriteLine(v);
            Console.WriteLine(v.GetHashCode());

        }
    }
}