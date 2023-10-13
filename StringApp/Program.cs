internal class Program
{
    private static void Main(string[] args)
    {
        string name = "John";
        int age = 30;

        // composite formatting
        Console.WriteLine("{0},{1}",name,age);

        // String Interpolation
        string message = $"My name is {name} and I am {age} years old.";
        Console.WriteLine(message);
    }
}