using Abp.Authorization;
using CPMS.Authorization.Roles;
using CPMS.Authorization.Users;

namespace CPMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
