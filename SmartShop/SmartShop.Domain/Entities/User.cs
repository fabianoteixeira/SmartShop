using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class User: Entity
    {
        public Customer Customer { get; set; }

        public Email Email { get; set; }

        public Password Password { get; set; }

        public string Profile { get; set; }
    }
}
