using Domain.Entities;
using FluentValidation;

namespace Domain.Entities.Validations
{
    public class PacienteValidation : AbstractValidator<Paciente>
    {
        public PacienteValidation()
        {
            RuleFor(p => p.Cpf)
                .NotNull()
                .NotEmpty()
                .Length(11)
                .WithMessage("Cpf é obrigatório");

            RuleFor(p => p.Nome)
                .NotNull()
                .NotEmpty()
                .Length(1, 35)
                .WithMessage("Nome é obrigatório e deve ter até 35 caracteres");

            RuleFor(p => p.Sexo)
                .NotNull()
                .NotEmpty()
                .Length(1)
                .WithMessage("Sexo é obrigatório");

            RuleFor(p => p.Cor)
                .NotNull()
                .NotEmpty()
                .Length(1, 10)
                .WithMessage("Cor é obrigatório");

            RuleFor(p => p.Nascimento)
                .NotNull()
                .WithMessage("Data de nascimento é obrigatória");
        }
    }
}
