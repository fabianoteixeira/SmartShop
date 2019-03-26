using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class City: Entity
    {
        public virtual State State { get; set; }

        public string Name { get; set; }

    }
}
