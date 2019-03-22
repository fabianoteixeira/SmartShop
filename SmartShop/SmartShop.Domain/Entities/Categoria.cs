using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Categoria: Entity
    {
        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }
    }
}
