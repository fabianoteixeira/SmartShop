using SmartShop.Domain.Commands.Categoria;

namespace SmartShop.Domain.Validations
{
    public class RegisterNewCategoriaValidation : CategoriaValidator<RegisterNewCategoria>
    {
        public RegisterNewCategoriaValidation()
        {
            ValidateDescricao();
        }
    }
}
