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
                .withMessage("Data deve ser informada");

            RuleFor(re => re.Id)
                .NotEqual(Guid.Empty)
                .withMessage("Id deve ser informado");

            RuleFor(re => re.Laudo)
                .NotNull()
                .NotEmpty()
                .withMessage("Laudo deve ser informado");

            RuleFor(re => re.Status)
                .NotNull()
                .NotEmpty()
                .withMessage("Status deve ser informado");

            RuleFor(re => re.IdDocente)
                .NotEqual(Guid.Empty)
                .withMessage("Docente deve ser informado");
                
            RuleFor(re => re.IdResidente)
                .NotEqual(Guid.Empty)
                .withMessage("Residente deve ser informado");

            RuleFor(re => re.IdPedidoExame)
                .NotEqual(Guid.Empty)
                .withMessage("Pedido de exame deve ser informado");

        }
    }

    public class RegistroExameVerification : AbstractValidator<RegistrosExamesAdicionar>
    {
        public RegistroExameVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(re => unitOfWork.RepositoryPedidoExame.ObterPorId(re.IdPedidoExame))
                .NotNull()
                .withMessage("Id não encontrado");
        }
    }
}