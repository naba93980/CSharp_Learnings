namespace ListPadhlo;

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>() { 5, 6 };
        list.Add(8);
        list.AddRange(new int[] { 1, 2, 3, 4 });  // takes any instance of a class that implements IEnumerable for eg. Array or List

        foreach (int e in list)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("index of 8 - " + list.IndexOf(8));
        Console.WriteLine("last index of 8 - " + list.LastIndexOf(8));
        // Remove() doesnot work inside foreach loop
        for (var i = 0; i < list.Count; i++)
        {
            Console.WriteLine(i+" ----"+list[i]);
            if(i==3){
                list.Remove(list[i]);
            }
        }

        foreach (var item in list)
        {
            Console.WriteLine(list.IndexOf(item)+"------"+item);
        }
    }
}