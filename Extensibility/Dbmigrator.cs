using System;
namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            Console.WriteLine("Migration started at {0}", DateTime.Now);

            // details of migrating database

            Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}
