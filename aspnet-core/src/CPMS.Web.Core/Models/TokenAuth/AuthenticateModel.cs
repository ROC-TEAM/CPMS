using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace CPMS.Models.TokenAuth
{
    /// <summary>
    /// 授权认证实体
    /// </summary>
    public class AuthenticateModel
    {
        /// <summary>
        /// 用户名或邮箱
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string Password { get; set; }
        
        /// <summary>
        /// 是否记住客户端 默认false
        /// </summary>
        public bool RememberClient { get; set; }
    }
}
