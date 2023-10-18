namespace FileHandling;

public class Directories
{
    public static void RunDir(){
        Directory.CreateDirectory(@"C:\Users\NABAJYOTI\Desktop\NewFolderBaby");
        string[] files = Directory.GetFiles(@"C:\Users\NABAJYOTI\Desktop\pics","*.jpeg",SearchOption.AllDirectories);
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
        string[] directories = Directory.GetDirectories(@"g:\Users\NABAJYOTI","*",SearchOption.TopDirectoryOnly);
        foreach (var dir in directories)
        {
            Console.WriteLine(dir);
        }
    }

    // DirectoryInfo very much similar to FileInfo
}
