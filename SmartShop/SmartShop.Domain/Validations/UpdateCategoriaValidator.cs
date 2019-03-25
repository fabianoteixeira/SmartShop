using SmartShop.Domain.Commands.Categoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Validations
{
    public class UpdateCategoriaValidator : CategoriaValidator<UpdateCategoria>
    {
        public UpdateCategoriaValidator()
        {
            ValidateDescricao();
        }
    }
}
