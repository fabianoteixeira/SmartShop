﻿using SmartShop.Domain.Validations.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Commands.Category
{
    public class DeleteCategory : CategoryCommand
    {
        public DeleteCategory(int id)
        {
            Id = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new DeleteCategoryValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
