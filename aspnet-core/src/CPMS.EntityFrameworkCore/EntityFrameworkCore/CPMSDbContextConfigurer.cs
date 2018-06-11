using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CPMS.EntityFrameworkCore
{
    public static class CPMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CPMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CPMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
