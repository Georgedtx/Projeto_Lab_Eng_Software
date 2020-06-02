using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.RegistrosExames
{
    public class RegistrosExamesAdicionar
    {
        public Guid Id {get ; private set; }
        public DateTime Data {get ; private set; }
        public String Laudo {get ; private set; }
        public bool Status {get ; private set; }
        public Guid? IdDocente {get ; private set; }
        public Guid? IdResidente { get; private set; }
        public Guid IdPedidoExame { get ; private set; }

        public ValidationResult Validation {get ; set; }

        public bool IsValid()
        {
            Validation = new RegistroExameValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class RegistroExameValidation : AbstractValidator<RegistrosExamesAdicionar>
    {
        public RegistroExameValidation()
        {
            RuleFor(re => re.Data)
                .NotEqual(new DateTime())
                .NotNull()
                .WithMessage("Data deve ser informada");

            RuleFor(re => re.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id deve ser informado");

            RuleFor(re => re.Laudo)
                .NotNull()
                .NotEmpty()
                .WithMessage("Laudo deve ser informado");

            RuleFor(re => re.Status)
                .NotNull()
                .NotEmpty()
                .WithMessage("Status deve ser informado");

            RuleFor(re => re.IdDocente)
                .NotEqual(Guid.Empty)
                .WithMessage("Docente deve ser informado");
                
            RuleFor(re => re.IdResidente)
                .NotEqual(Guid.Empty)
                .WithMessage("Residente deve ser informado");

            RuleFor(re => re.IdPedidoExame)
                .NotEqual(Guid.Empty)
                .WithMessage("Pedido de exame deve ser informado");

        }
    }

    public class RegistroExameVerification : AbstractValidator<RegistrosExamesAdicionar>
    {
        public RegistroExameVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(re => unitOfWork.RepositoryPedidoExame.ObterPorId(re.IdPedidoExame))
                .NotNull()
                .WithMessage("Id não encontrado");
        }
    }
}