using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CPMS.Authorization.Roles;
using CPMS.Authorization.Users;
using CPMS.MultiTenancy;

namespace CPMS.EntityFrameworkCore
{
    public class CPMSDbContext : AbpZeroDbContext<Tenant, Role, User, CPMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CPMSDbContext(DbContextOptions<CPMSDbContext> options)
            : base(options)
        {
        }
    }
}
