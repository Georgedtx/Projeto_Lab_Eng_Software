using FluentValidation;

namespace Domain.Entities.Validations
{
    public class ExameValidation : AbstractValidator<Exame>
    {
        public ExameValidation()
        {
            RuleFor(e => e.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome do exame é obrigatório")
                .Length(1, 25)
                .WithMessage("Nome deve ter até 25 caracteres");
            
            RuleFor(e => e.Descricao)
                .NotEmpty()
                .NotNull()
                .WithMessage("Uma descrição é obrigatória")
                .Length(1, 200)
                .WithMessage("Descrição deve ter até 200 caracteres");
        }
    }
}
