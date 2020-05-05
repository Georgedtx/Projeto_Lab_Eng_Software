using Domain.Interfaces.Uow;
using Domain.Validations;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.Pacientes
{
    public class PacienteAdicionar
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public DateTime Nascimento { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new PacienteValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class PacienteValidation : AbstractValidator<PacienteAdicionar>
    {
        public PacienteValidation()
        {
            RuleFor(p => p.Cpf)
                .NotNull()
                .NotEmpty()
                .WithMessage("Cpf é obrigatório");

            RuleFor(p => CPFValidation.Validar(p.Cpf))
                .Equal(true)
                .WithMessage("Informe um cpf válido");

            RuleFor(p => p.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome é obrigatório")
                .Length(1, 35)
                .WithMessage("Nome deve ter até 35 caracteres");

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

    public class PacienteVerification : AbstractValidator<PacienteAdicionar>
    {
        public PacienteVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(p => unitOfWork.RepositoryPaciente.ObterPorCpf(p.Cpf))
                .Null()
                .WithMessage("Cpf informado já utilizado!");
        }
    }
}
