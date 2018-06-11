using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CPMS.Configuration;
using CPMS.Web;

namespace CPMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CPMSDbContextFactory : IDesignTimeDbContextFactory<CPMSDbContext>
    {
        public CPMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CPMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CPMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CPMSConsts.ConnectionStringName));

            return new CPMSDbContext(builder.Options);
        }
    }
}
