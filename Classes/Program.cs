namespace ClassChapter;

using Classes;

class Program
{
    private static void Main(string[] args)
    {
        // object initializer is used here
        Person person = new()        
        {
            name = "Naba",                              
            id = 1
        };


        Property prop1 = new Property(23);
        prop1.Name = "Nabajyoti";
        prop1.Id = 2;
        
        Console.WriteLine(prop1.Name);
        Console.WriteLine(prop1.Id);
        Console.WriteLine(prop1.Age);
    }
}

