using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class State: Entity

    {
        public string Abbreviation { get; set; }

        public string Name { get; set; }

    }
}
