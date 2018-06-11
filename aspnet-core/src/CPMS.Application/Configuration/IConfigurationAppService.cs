using System.Threading.Tasks;
using CPMS.Configuration.Dto;

namespace CPMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
