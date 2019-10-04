using SmartShop.Domain.Commands.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Validations.Category
{
    public class DeleteCategoryValidator :  CategoryValidator<DeleteCategory>
    {
        public DeleteCategoryValidator()
        {
            ValidateId();
        }
    }
}
