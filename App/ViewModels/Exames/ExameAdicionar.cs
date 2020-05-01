using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;

namespace App.ViewModels.Exames
{
    public class ExameAdicionar
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new ExameValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class ExameValidation : AbstractValidator<ExameAdicionar>
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
                .WithMessage("Descrição é obrigatória")
                .Length(1, 200)
                .WithMessage("Descrição deve ter até 200 caracteres");
        }
    }

    public class ExameVerification : AbstractValidator<ExameAdicionar>
    {
        public ExameVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(e => unitOfWork.RepositoryExame.ObterPorNome(e.Nome))
                .Null()
                .WithMessage("Nome de exame já utilizado");
        }
    }
}
