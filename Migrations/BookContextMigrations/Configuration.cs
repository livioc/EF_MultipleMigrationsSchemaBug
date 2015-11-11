namespace MultipleMigrationsSchemaBug.Migrations.BookContextMigrations
{
    using System.Data.Entity.Migrations;
    using Dal;

    internal sealed class Configuration : DbMigrationsConfiguration<BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\BookContextMigrations";
        }

        protected override void Seed(BookContext context)
        {
        }
    }
}
