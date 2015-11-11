using System.Data.Entity;
using MultipleMigrationsSchemaBug.Domain;

namespace MultipleMigrationsSchemaBug.Dal
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users
        {
            get;
            set;
        }

        public UserContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<UserContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");
        }
    }
}
