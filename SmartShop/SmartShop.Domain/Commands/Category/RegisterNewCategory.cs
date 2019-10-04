using MediatR;
using SmartShop.Domain.Validations;

namespace SmartShop.Domain.Commands.Category
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
