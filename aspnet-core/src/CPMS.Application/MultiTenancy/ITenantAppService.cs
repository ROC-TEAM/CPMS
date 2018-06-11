using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CPMS.MultiTenancy.Dto;

namespace CPMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
