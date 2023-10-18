namespace FileHandling;

public class FileClass
{
    public static void RunFile(){
        File.Copy(@"C:\Users\NABAJYOTI\Desktop\MOTHER PIC.jpeg",@"C:\Users\NABAJYOTI\Desktop\pics\MOTHER PIC.jpeg",true);

        if(File.Exists(@"C:\Users\NABAJYOTI\Desktop\MOTHER PIC.jpeg") && File.Exists(@"C:\Users\NABAJYOTI\Desktop\pics\MOTHER PIC.jpeg")) {
            File.Delete(@"C:\Users\NABAJYOTI\Desktop\MOTHER PIC.jpeg");
        }
        else Console.WriteLine("File cant be deleted");

        byte[] v = File.ReadAllBytes(@"C:\Users\NABAJYOTI\Desktop\pics\MOTHER PIC.jpeg");
    }
}
// using File class has overheads as when u call static methods the os does some security checking, so use File class
// for a few times, or frequent calling of methods on file use FileInfo class