using FluentValidation;
using SmartShop.Domain.Validations;

namespace SmartShop.Domain.Commands.Category
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
