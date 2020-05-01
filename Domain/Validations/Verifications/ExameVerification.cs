using Domain.Entities;
using Domain.Interfaces.Repositories;
using FluentValidation;

namespace Domain.Validations.Verifications
{
    public class ExameVerification : AbstractValidator<Exame>
    {
        public ExameVerification(IRepositoryExame repositoryExame)
        {
            RuleFor(e => repositoryExame.ObterPorNome(e.Nome))
                .Null()
                .WithMessage("Nome de exame já utilizado");
        }
    }
}
