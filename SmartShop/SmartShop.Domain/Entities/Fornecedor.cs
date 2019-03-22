using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Fornecedor: Entity
    {
        public int IdLogradouro { get; set; }
        public virtual Logradouro Logradouro { get; set; }
        public string NomeFantasia { get; set; }

        public Cnpj Cnpj { get; set; }

        public string InscricaoEstadual { get; set; }

        public string RazaoSocial { get; set; }

        public Email Email { get; set; }

        public string Telefone { get; set; }

        public string Observacoes { get; set; }

    }
}
