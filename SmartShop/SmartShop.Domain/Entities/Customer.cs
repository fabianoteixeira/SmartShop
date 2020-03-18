using SmartShop.Domain.Core.Entities;
using SmartShop.Domain.ValueObjects;
using System;

namespace SmartShop.Domain.Entities
{
    public class Customer : Entity
    {
        public virtual Street Street { get; set; }

        public Name Name { get; set; }

        public Cpf cpf { get; set; }

        public Rg rg { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string CellPhone { get; set; }

        public DateTime? RegistrationDate { get; set; }

    }
}
