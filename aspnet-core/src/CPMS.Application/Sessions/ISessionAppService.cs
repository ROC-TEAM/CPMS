using System.Threading.Tasks;
using Abp.Application.Services;
using CPMS.Sessions.Dto;

namespace CPMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
