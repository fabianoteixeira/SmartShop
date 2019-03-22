using SmartShop.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public abstract class CategoriaCommand : Command
    {
        public string Descricao { get; protected set; }
    }
}
