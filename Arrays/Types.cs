namespace Arrays;

public class Types
{
    public static void rectangular()
    {
        int[,] v = new int[2, 2]{
            {1,2},
            {3,4},
        };

        Console.WriteLine("length of rectangular array : " + v.Length);
        foreach (var item in v)
        {
            Console.WriteLine(item);
        }
    }

    public static void jagged()
    {
        int[][] v = new int[2][]{
            new int[2] { 1, 2 },
            new int[2] { 3, 4 }
        };

        Console.WriteLine("length of jagged array : " + v.Length);
        foreach (var items in v)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
