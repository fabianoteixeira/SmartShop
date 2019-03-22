using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Logradouro : Entity
    {

        public int IdBairro { get; set; }
        public virtual Bairro Bairro { get; set; }        

        public string Nome { get; set; }

        public string NroCepLogradouro { get; set; }

    }
}
