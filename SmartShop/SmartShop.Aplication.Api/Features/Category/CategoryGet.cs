using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Services.Api.Features.Category
{
    public class CategoryGet
    {
        public CategoryGet(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
