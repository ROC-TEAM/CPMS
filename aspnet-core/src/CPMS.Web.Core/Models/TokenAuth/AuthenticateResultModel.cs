namespace CPMS.Models.TokenAuth
{
    /// <summary>
    /// 授权认证结果实体
    /// </summary>
    public class AuthenticateResultModel
    {
        /// <summary>
        /// token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 加密的token
        /// </summary>
        public string EncryptedAccessToken { get; set; }

        /// <summary>
        /// 过期时间 (单位 秒)
        /// </summary>
        public int ExpireInSeconds { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }
    }
}
