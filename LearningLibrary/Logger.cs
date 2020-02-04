using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating");
        }
    }

    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            logger.Log("We are installing the application.");
        }
    }
}
