using SmartShop.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public class UpdateCategory : CategoryCommand
    {
       
        public UpdateCategory(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCategoryValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
