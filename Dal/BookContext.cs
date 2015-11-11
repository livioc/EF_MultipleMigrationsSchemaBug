using System.Data.Entity;
using MultipleMigrationsSchemaBug.Domain;

namespace MultipleMigrationsSchemaBug.Dal
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books
        {
            get;
            set;
        }

        public BookContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<BookContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");
        }
    }
}
