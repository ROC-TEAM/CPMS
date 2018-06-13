namespace CPMS.Authorization.Accounts.Dto
{
    /// <summary>
    /// 租户可用输出参数
    /// </summary>
    public class IsTenantAvailableOutput
    {
        /// <summary>
        /// 状态
        /// </summary>
        public TenantAvailabilityState State { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public int? TenantId { get; set; }

        public IsTenantAvailableOutput()
        {
        }

        public IsTenantAvailableOutput(TenantAvailabilityState state, int? tenantId = null)
        {
            State = state;
            TenantId = tenantId;
        }
    }
}
