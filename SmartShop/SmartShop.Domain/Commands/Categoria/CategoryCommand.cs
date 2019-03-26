using SmartShop.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public abstract class CategoryCommand : Command
    {
        public string Description { get; protected set; }
    }
}
