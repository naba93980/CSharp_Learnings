namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie = new Cookie();
            cookie["lunch"] = "Veg";            // without indexer it would be cookie.Item["key"] = "value"
            cookie["Dinner"] = "Chicken";

            Console.WriteLine(cookie["lunch"]);
        }
    }
}