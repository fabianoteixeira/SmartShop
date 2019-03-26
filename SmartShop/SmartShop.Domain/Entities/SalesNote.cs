using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class SalesNote: Entity
    {
        public Customer Customer { get; set; }

        public decimal? Amount { get; set; }

        public DateTime SaleDate { get; set; }

        public DateTime Date { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Value { get; set; }

    }

}
