using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class District: Entity
    {
        public virtual City City { get; set; } 

        public string Name { get; set; }

    }
}
