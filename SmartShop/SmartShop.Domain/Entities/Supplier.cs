using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Supplier: Entity
    {
       
        public virtual Street Street { get; set; }
        public string BusinessName { get; set; }

        public Cnpj Cnpj { get; set; }

        public string StateRegistration { get; set; }

        public string  SocialName { get; set; }

        public Email Email { get; set; }

        public string Phone { get; set; }

        public string Comments { get; set; }

    }
}
