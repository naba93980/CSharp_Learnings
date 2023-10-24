namespace Extensibility;
public class DBMigrator
{
    private readonly ILogger _logger;

    public DBMigrator(ILogger logger)
    {
        this._logger = logger;
    }
    public void Migrate()
    {
        _logger.LogInfo("Migration started");
        _logger.LogInfo("Migration finished");
    }
}

// this is Open closed principle, the class open for extension (using any logger implementation)
// but closed for modification (anything inside this file cant be changed)