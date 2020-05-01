using Domain.Entities.Validations;
using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;

namespace App.ViewModels.Administradores
{
    public class AdministradorAdicionar
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string RepetirSenha { get; set; }
        public string Nome { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new AdministradorValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class AdministradorValidation : AbstractValidator<AdministradorAdicionar>
    {
        public AdministradorValidation()
        {
            RuleFor(r => r.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome do Administrador é obrigatório")
                .Length(1, 30)
                .WithMessage("Nome deve ter até 30 caracteres");

            RuleFor(u => EmailValidation.Validate(u.Email))
                .Equal(true)
                .WithMessage("Email válido deve ser informado");

            RuleFor(u => SenhaValidation.Validate(u.Senha))
                .Equal(true)
                .WithMessage("Informe uma senha de 8 a 10 caracteres incluindo letras maiúsculas, minúsculas e números");

            RuleFor(u => u.RepetirSenha)
                .Equal(u => u.Senha)
                .WithMessage("Senhas informadas são diferentes");
        }
    }

    public class AdministradorVerification : AbstractValidator<AdministradorAdicionar>
    {
        public AdministradorVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(u => unitOfWork.RepositoryUsuario.ObterPorEmail(u.Email))
                .Null()
                .WithMessage("Email de usuário já utilizado");
        }
    }
}
