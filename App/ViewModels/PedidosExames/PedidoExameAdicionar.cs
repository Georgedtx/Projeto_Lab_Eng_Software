using Domain.Interfaces.Uow;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.PedidosExames
{
    public class PedidoExameAdicionar
    {
        public DateTime DataEmissao { get; set; }
        public DateTime DataRealizacao { get; set; }
        public string Hipotese { get; set; }
        public string Recomendacoes { get; set; }
        public Guid IdExame { get; set; }
        public string Exame { get; set; }

        public string Crm { get; set; }

        public Guid IdPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string SexoPaciente { get; set; }
        public int IdadePaciente { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new PedidoExameValidation().Validate(this);
            return Validation.IsValid;
        }
    }

    public class PedidoExameValidation : AbstractValidator<PedidoExameAdicionar>
    {
        public PedidoExameValidation()
        {
            RuleFor(pe => pe.DataRealizacao)
                .NotEqual(new DateTime())
                .NotNull()
                .WithMessage("Data de Realização deve ser informada");

            RuleFor(pe => pe.Hipotese)
                .NotNull()
                .NotEmpty()
                .WithMessage("Hipotese(s) deve(m) ser informada(s)");

            RuleFor(pe => pe.IdPaciente)
                .NotEqual(Guid.Empty)
                .WithMessage("Paciente deve ser informado");

            RuleFor(pe => pe.IdExame)
                .NotEqual(Guid.Empty)
                .WithMessage("Exame a ser feito deve ser informado");

            RuleFor(pe => pe.Crm)
                .NotEmpty()
                .WithMessage("Crm do médico solicitante deve ser informado");

        }

    }

    public class PedidoExameVerification : AbstractValidator<PedidoExameAdicionar>
    {
        public PedidoExameVerification(IUnitOfWork unitOfWork)
        {
            RuleFor(pe => unitOfWork.RepositoryMedico.ObterPorCrm(pe.Crm))
                .NotNull()
                .WithMessage("Crm incorreto");
        }
    }
}