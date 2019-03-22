using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Cliente : Entity
    {
        public virtual Logradouro Logradouro { get; set; }

        public Nome Nome { get; set; }

        public Cpf cpf { get; set; }

        public Rg rg { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public DateTime? DataCadastro { get; set; }

    }
}
