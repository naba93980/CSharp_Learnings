namespace Extensibility;

public class FileLogger : ILogger
{
    public void LogError(string message)
    {
        Console.WriteLine(message + " in file");
    }

    public void LogInfo(string message)
    {
        Console.WriteLine(message + " in file");
    }
}
