using FluentValidation;
using SmartShop.Domain.Commands.Categoria;

namespace SmartShop.Domain.Validations
{
    public class CategoryValidator<T>: AbstractValidator<T> where T: CategoryCommand
    {
        protected void ValidateDescription()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição não pode ser vazia");
        }


    }
}
