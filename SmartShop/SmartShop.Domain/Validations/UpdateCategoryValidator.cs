using SmartShop.Domain.Commands.Categoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Validations
{
    public class UpdateCategoryValidator : CategoryValidator<UpdateCategory>
    {
        public UpdateCategoryValidator()
        {
            ValidateDescription();
        }
    }
}
