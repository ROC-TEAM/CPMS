using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CPMS.Configuration.Dto;

namespace CPMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CPMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
