using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Product: Entity
    {
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Category Category { get; set; }
        public string Description { get; set; }

        public int Quantity { get; set; }

        public string ProductImage { get; set; }

        public decimal? PurchaseValue { get; set; }

        public decimal? SaleValue { get; set; }
    }
}
