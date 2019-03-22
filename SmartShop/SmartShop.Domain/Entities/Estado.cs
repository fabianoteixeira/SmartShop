using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Estado: Entity

    {
        public string Sigla { get; set; }

        public string Nome { get; set; }

    }
}
