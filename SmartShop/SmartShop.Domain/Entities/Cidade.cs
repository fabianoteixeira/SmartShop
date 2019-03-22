using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Cidade: Entity
    {
        public virtual Estado Estado { get; set; }

        public string nome { get; set; }

    }
}
