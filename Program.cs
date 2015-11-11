using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MultipleMigrationsSchemaBug
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
#if WORKAROUND
                DbConfiguration.SetConfiguration(new MultipleMigrationsSchemaBug.Dal.PgConfiguration());
#endif
                ResetDb();
            }
            catch (Exception e)
            {
                Console.Write(e);
                Console.ReadLine();
            }

        }

        static void ResetDb()
        {
            using (var context = new DbContext("DefaultConnection"))
            {
                context.Database.Delete();
            }

            // recreate the database with migrations
            var configs = new DbMigrationsConfiguration[]
            {
                new Migrations.BookContextMigrations.Configuration(),
                new Migrations.UserContextMigrations.Configuration()
            };
            foreach (var config in configs)
            {
                var migrator = new DbMigrator(config);
                migrator.Update();
            }
        }
    }
}
