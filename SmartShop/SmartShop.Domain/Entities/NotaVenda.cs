using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class NotaVenda: Entity
    {
        public int id_cliente { get; set; }

        public decimal? valor_total { get; set; }

        public DateTime data_venda { get; set; }

        public DateTime horario { get; set; }

        public decimal? desconto { get; set; }

        public decimal? valor { get; set; }

    }

}
