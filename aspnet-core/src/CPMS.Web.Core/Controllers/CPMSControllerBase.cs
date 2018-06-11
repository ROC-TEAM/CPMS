using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CPMS.Controllers
{
    public abstract class CPMSControllerBase: AbpController
    {
        protected CPMSControllerBase()
        {
            LocalizationSourceName = CPMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
