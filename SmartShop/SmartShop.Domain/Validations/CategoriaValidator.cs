using FluentValidation;
using SmartShop.Domain.Commands.Categoria;

namespace SmartShop.Domain.Validations
{
    public class CategoriaValidator<T>: AbstractValidator<T> where T: CategoriaCommand
    {
        protected void ValidateDescricao()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("A descrição não pode ser vazia");
        }


    }
}
