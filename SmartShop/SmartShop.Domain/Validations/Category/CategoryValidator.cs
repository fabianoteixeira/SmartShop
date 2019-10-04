using FluentValidation;
using SmartShop.Domain.Commands.Category;

namespace SmartShop.Domain.Validations
{
    public class CategoryValidator<T>: AbstractValidator<T> where T: CategoryCommand
    {
        protected void ValidateDescription()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição não pode ser vazia");
        }


        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("O id não estar preenchido");
        }


    }
}
