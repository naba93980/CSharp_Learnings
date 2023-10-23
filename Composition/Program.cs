namespace Composition
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Migrator migrator = new Migrator(logger);
            migrator.Migrate();
            Installer installer = new Installer(logger);
            installer.Install();

        }
    }
}