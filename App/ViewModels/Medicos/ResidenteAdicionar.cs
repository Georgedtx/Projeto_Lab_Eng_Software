using Domain.Entities.Validations;
using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.Medicos
{
    public class ResidenteAdicionar
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string RepetirSenha { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public int AnoResidencia { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new ResidenteValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class ResidenteValidation : AbstractValidator<ResidenteAdicionar>
    {
        public ResidenteValidation()
        {
            RuleFor(u => EmailValidation.Validate(u.Email))
                .Equal(true)
                .WithMessage("Um Email válido deve ser informado");

            RuleFor(u => SenhaValidation.Validate(u.Senha))
                .Equal(true)
                .WithMessage("Informe uma senha de 8 a 10 caracteres incluindo letras maiúsculas, minúsculas e números");

            RuleFor(u => u.RepetirSenha)
                .Equal(u => u.Senha)
                .WithMessage("Senhas informadas são diferentes");

            RuleFor(m => m.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório")
                .Length(1, 30)
                .WithMessage("Nome deve ter até 30 caracteres");

            RuleFor(m => m.Crm)
                .NotNull()
                .NotNull()
                .Length(1, 10)
                .WithMessage("Crm é obrigatório");

            RuleFor(r => r.AnoResidencia)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now.Year)
                .GreaterThan(1900)
                .WithMessage("Ano de residência válido é obrigatório");
        }
    }

    public class ResidenteVerification : AbstractValidator<ResidenteAdicionar>
    {
        public ResidenteVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(m => unitOfWork.RepositoryMedico.ObterPorCrm(m.Crm))
                .Null()
                .WithMessage("Crm já utilizado");

            RuleFor(u => unitOfWork.RepositoryUsuario.ObterPorEmail(u.Email))
                .Null()
                .WithMessage("Email de usuário já utilizado");
        }
    }
}
