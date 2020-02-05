using System;

namespace DataBaseMigrate
{

    public class DbMigrator
    {
        public readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }        

        public void Migrate()
        {
            _logger.LogInfo($"Migration started { DateTime.Now}");
            _logger.LogError($"Migration finished {DateTime.Now}");
                     
        }
    }
}
