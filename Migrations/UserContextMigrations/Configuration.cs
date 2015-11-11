namespace MultipleMigrationsSchemaBug.Migrations.UserContextMigrations
{
    using System.Data.Entity.Migrations;
    using Dal;

    internal sealed class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\UserContextMigrations";
        }

        protected override void Seed(UserContext context)
        {
        }
    }
}
