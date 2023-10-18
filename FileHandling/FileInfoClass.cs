namespace FileHandling;

public class FileInfoClass
{
    public static void RunFileInfo(){
        FileInfo fileInfo = new FileInfo(@"C:\Users\NABAJYOTI\Desktop\FATHER PIC.jpeg");
        FileInfo copyFile = fileInfo.CopyTo(@"C:\Users\NABAJYOTI\Desktop\pics\FATHER PIC.jpeg",true);
        if(copyFile.Exists){
            fileInfo.Delete();
        }
    }
}
