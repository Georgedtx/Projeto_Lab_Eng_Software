using Domain.Entities.Validations;
using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.Recepcionistas
{
    public class RecepcionistaAdicionar
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string RepetirSenha { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new RecepcionistaValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class RecepcionistaValidation : AbstractValidator<RecepcionistaAdicionar>
    {
        public RecepcionistaValidation()
        {
            RuleFor(u => EmailValidation.Validate(u.Email))
                .Equal(true)
                .WithMessage("Email válido deve ser informado");

            RuleFor(u => SenhaValidation.Validate(u.Senha))
                            .Equal(true)
                            .WithMessage("Informe uma senha de 8 a 10 caracteres incluindo letras maiúsculas, minúsculas e números");

            RuleFor(u => u.RepetirSenha)
                .Equal(u => u.Senha)
                .WithMessage("Senhas informadas são diferentes");

            RuleFor(r => r.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome do(a) Recepcionista é obrigatório")
                .Length(1, 30)
                .WithMessage("Nome deve ter até 30 caracteres");

            RuleFor(r => r.Nascimento)
                .NotEqual(new DateTime())
                .WithMessage("Data de nascimento é obrigatória");

            RuleFor(r => VerificarMaioridade(r.Nascimento))
                .Equal(true)
                .WithMessage("Recepcionista não pode ser menor de idade");
        }

        public bool VerificarMaioridade(DateTime nascimento)
        {
            var idade = DateTime.Now.Year - nascimento.Year;

            if (DateTime.Now.Month < nascimento.Month)
            {
                idade--;
            }
            if (DateTime.Now.Month == nascimento.Month && DateTime.Now.Day < nascimento.Day)
            {
                idade--;
            }
            return (idade >= 18);
        }
    }

    public class RecepcionistaVerification : AbstractValidator<RecepcionistaAdicionar>
    {
        public RecepcionistaVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(u => unitOfWork.RepositoryUsuario.ObterPorEmail(u.Email.ToLower()))
                .Null()
                .WithMessage("Email de usuário já utilizado");
        }
    }
}
