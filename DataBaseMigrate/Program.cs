using System;

namespace DataBaseMigrate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"D:\Learning_C#\Courses\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
