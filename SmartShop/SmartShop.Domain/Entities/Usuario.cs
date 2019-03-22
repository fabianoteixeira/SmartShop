using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Usuario: Entity
    {
        public int IdCliente { get; set; }

        public Email Email { get; set; }

        public Senha Senha { get; set; }

        public string Perfil { get; set; }
    }
}
