using SmartShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Domain.Queries
{
    public interface ICategoryQueries
    {
    
        List<CategoryViewModel> GetAll();
    }
}
