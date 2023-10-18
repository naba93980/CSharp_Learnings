namespace FileHandling;

public class PathClass
{
    public static void RunPath()
    {
        string path = @"G:\Users\NABAJYOTI\C#_Learnings\C#_Learnings.sln";
        Console.WriteLine("Extension:  " + Path.GetExtension(path));
        Console.WriteLine("File Name:  " + Path.GetFileName(path));
        Console.WriteLine("File Name without extension:  " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name:  " + Path.GetDirectoryName(path));
    }
}
