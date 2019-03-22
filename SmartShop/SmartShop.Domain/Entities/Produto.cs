using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Produto: Entity
    {
        public int IdFabricante { get; set; }
        public virtual Fabricante Fabricante { get; set; }

        public virtual Categoria Categoria { get; set; }
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public string ImagemProduto { get; set; }

        public decimal? ValorCompra { get; set; }

        public decimal? ValorVenda { get; set; }
    }
}
