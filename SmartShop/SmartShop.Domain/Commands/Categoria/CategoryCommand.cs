using SmartShop.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public abstract class CategoryCommand : Command
    {
        public int Id { get; set; }
        public string Description { get; protected set; }
    }
}
