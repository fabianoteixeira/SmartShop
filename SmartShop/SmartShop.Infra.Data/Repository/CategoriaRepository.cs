using SmartShop.Domain.Entities;
using SmartShop.Domain.Interfaces;
using SmartShop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Infra.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, IRepositoryCategoria
    {
        public CategoriaRepository(SmartShopContext context)
            :base(context)
        {

        }


    }
}
