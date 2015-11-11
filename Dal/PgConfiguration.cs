#if WORKAROUND
		
using System.Data.Entity;

namespace MultipleMigrationsSchemaBug.Dal
{
    class PgConfiguration : DbConfiguration
    {
        public PgConfiguration()
        {
            SetHistoryContext("Npgsql",
                (connection, defaultSchema) => new PgHistoryContext(connection, defaultSchema));
        }
    }
} 

#endif
