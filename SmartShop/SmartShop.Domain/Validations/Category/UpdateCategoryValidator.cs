using SmartShop.Domain.Commands.Category;
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
