using SmartShop.Domain.Interfaces;
using SmartShop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Infra.Data.UoW
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly SmartShopContext _context;

        public UnitOfWork(SmartShopContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
