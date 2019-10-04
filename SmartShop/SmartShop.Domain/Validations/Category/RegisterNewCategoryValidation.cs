using SmartShop.Domain.Commands.Category;

namespace SmartShop.Domain.Validations
{
    public class RegisterNewCategoryValidation : CategoryValidator<RegisterNewCategory>
    {
        public RegisterNewCategoryValidation()
        {
            ValidateDescription();
        }
    }
}
