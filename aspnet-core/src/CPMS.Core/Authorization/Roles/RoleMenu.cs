using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;
using Abp.Domain.Entities;

namespace CPMS.Authorization.Roles
{
    [Table("AbpRoleMenus")]
    public class RoleMenu : Entity<long>, IMayHaveTenant
    {
        public virtual int? TenantId { get; set; }

        [Required]
        public virtual int RoleId { get; set; }

        [Required]
        public virtual int MenuId { get; set; }
    }
}
