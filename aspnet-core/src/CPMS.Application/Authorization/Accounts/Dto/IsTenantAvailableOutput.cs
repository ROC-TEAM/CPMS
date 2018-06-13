namespace CPMS.Authorization.Accounts.Dto
{
    /// <summary>
    /// �⻧�����������
    /// </summary>
    public class IsTenantAvailableOutput
    {
        /// <summary>
        /// ״̬
        /// </summary>
        public TenantAvailabilityState State { get; set; }

        /// <summary>
        /// �⻧ID
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
