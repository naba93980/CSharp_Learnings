internal class Program
{
    private static void Main(string[] args)
    {
        string name = "John";
        int age = 30;
        int[] no = new int[] { 1, 2, 3 };

        // composite formatting
        Console.WriteLine("{0},{1}", name, age);

        // String Interpolation
        string message = $"My name is {name} and I am {age} years old.";
        Console.WriteLine(message);

        // String literal objects stays in intern pool
        String name2 = "Hello";
        System.Console.WriteLine(name2 is String);
        System.Console.WriteLine(name2.GetType());

        String v = String.Format("{0},{1}", name, age);   // placeholders are represented by {} & are zero indexed
        System.Console.WriteLine(v);

        string v1 = String.Join(',',no);
        Console.WriteLine(v1);

        String escapeCharPath = "c:\\Users\\NABAJYOTI\\Desktop";
        Console.WriteLine(escapeCharPath);
        String verbatimStringPath = @"c:\Users\NABAJYOTI\Desktop
        no need of escaped \n";
        Console.WriteLine(verbatimStringPath);
        
    }
}