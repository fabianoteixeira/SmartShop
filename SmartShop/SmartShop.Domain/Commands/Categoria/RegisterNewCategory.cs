using SmartShop.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public class RegisterNewCategory : CategoryCommand
    {
        public RegisterNewCategory(string description)
        {
            Description = description; 
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCategoryValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
