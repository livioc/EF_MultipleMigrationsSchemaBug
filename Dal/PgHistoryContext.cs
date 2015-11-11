#if WORKAROUND

using System.Data.Common;
using System.Data.Entity.Migrations.History;

namespace MultipleMigrationsSchemaBug.Dal
{
    public class PgHistoryContext : HistoryContext
    {
        public PgHistoryContext(DbConnection existingConnection, string defaultSchema)
            : base(existingConnection, "public")
        {
        }
    } 
}
    
#endif
