using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Configuration;
using Abp.Localization;
using CPMS.Authorization.Menus;

namespace CPMS.EntityFrameworkCore.Seed.Host
{
    public class DefaultMenuCreator
    {
        private readonly CPMSDbContext _context;

        public DefaultMenuCreator(CPMSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            AddDefaultMenu(0);
        }

        private void AddDefaultMenu(int parentId)
        {
            if (_context.Menus.IgnoreQueryFilters().Any(m => m.ParentId == parentId))
            {
                return;
            }
            var menu = new Menu()
            {
                ParentId = parentId,
                Name = CPMSConsts.DefaultRootMenuName,
                Code = CPMSConsts.DefaultRootMenuCode,
                Type = MenuType.Root
            };
            _context.Menus.Add(menu);
            _context.SaveChanges();
        }
    }
}
