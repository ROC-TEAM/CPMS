using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace CPMS.Authorization.Accounts.Dto
{
    /// <summary>
    /// 租户可用输入参数
    /// </summary>
    public class IsTenantAvailableInput
    {
        /// <summary>
        /// 租户名称
        /// </summary>
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
