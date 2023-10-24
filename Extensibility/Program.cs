namespace Extensibility;
internal class Program
{
    static void Main(string[] args)
    {
        DBMigrator dBMigrator = new DBMigrator(new Logger());
        dBMigrator.Migrate();

        DBMigrator dBMigrator2 = new DBMigrator(new FileLogger()); ;
        dBMigrator2.Migrate();
    }
}
