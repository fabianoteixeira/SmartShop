using SmartShop.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public class RegisterNewCategoria : CategoriaCommand
    {
        public RegisterNewCategoria(string descricao)
        {
            Descricao = descricao; 
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCategoriaValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
