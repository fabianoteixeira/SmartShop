using SmartShop.Domain.Validations.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Categoria
{
    public class DeleteCategory : CategoryCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new DeleteCategoryValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
