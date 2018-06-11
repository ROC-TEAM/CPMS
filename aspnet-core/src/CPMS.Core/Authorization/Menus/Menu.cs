using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;

namespace CPMS.Authorization.Menus
{
    [Table("AbpMenus")]
    [MultiTenancySide(MultiTenancySides.Host)]

    public class Menu : FullAuditedEntity
    {
        [Required]
        [StringLength(100)]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Code { get; set; }

        [StringLength(300)]
        public virtual string IMG { get; set; }

        [StringLength(300)]
        public virtual string URL { get; set; }

        [Required]
        public virtual MenuType Type { get; set; }

        [Required]
        public virtual int ParentId { get; set; }

        [StringLength(100)]
        public virtual string ClassName { get; set; }

        public virtual int SortId { get; set; }

        [Required]
        public virtual bool Enabled { get; set; }

        public Menu()
        {
            this.SortId = 100;
            this.Enabled = true;
        }
    }
}
