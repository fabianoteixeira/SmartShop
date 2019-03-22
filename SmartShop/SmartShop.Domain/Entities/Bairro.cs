using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Bairro: Entity
    {
        public int IdCidade { get; set; }
        public virtual Cidade Cidade { get; set; } 

        public string Nome { get; set; }

    }
}
