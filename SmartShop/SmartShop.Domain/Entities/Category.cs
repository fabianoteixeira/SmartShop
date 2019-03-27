using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Category: Entity
    {
        public Category(string description)
        {
            Description = description;
        }


        public Category(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public string Description { get; set; }
    }
}
