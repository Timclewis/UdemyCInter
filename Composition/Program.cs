using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var dbmigrator = new DbMigrator(logger);
            var installer = new Installer(logger);

            dbmigrator.Migrate();
            installer.Install();

        }
    }
}
