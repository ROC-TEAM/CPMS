using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace CPMS.Authorization
{
    public class CPMSAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L(PermissionNames.Pages_Users));
            var rolePermission = context.CreatePermission(PermissionNames.Pages_Roles, L(PermissionNames.Pages_Roles));
            rolePermission.CreateChildPermission(PermissionNames.Pages_Roles_Add, L(PermissionNames.Pages_Roles_Add));
            rolePermission.CreateChildPermission(PermissionNames.Pages_Roles_Update, L(PermissionNames.Pages_Roles_Update));
            rolePermission.CreateChildPermission(PermissionNames.Pages_Roles_Delete, L(PermissionNames.Pages_Roles_Delete));
            rolePermission.CreateChildPermission(PermissionNames.Pages_Roles_Query, L(PermissionNames.Pages_Roles_Query));

            context.CreatePermission(PermissionNames.Pages_Tenants, L(PermissionNames.Pages_Tenants), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, CPMSConsts.LocalizationSourceName);
        }
    }
}
