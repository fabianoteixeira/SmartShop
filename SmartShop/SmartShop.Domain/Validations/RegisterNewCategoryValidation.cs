using SmartShop.Domain.Commands.Categoria;

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
