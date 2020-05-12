using FluentValidation;
using FluentValidation.Results;
using System;

namespace App.ViewModels.PedidosExames
{
    public class PedidoExameAdicionar 
    {
        public Guid Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataRealizacao { get; set; }
        public string Hipotese { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdExame { get; set; }
        public Guid IdMedico { get; set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new PedidoExameValidation().Validate(this);
            return Validation.IsValid;
        }

        public class PedidoExameValidation : AbstractValidator<PedidoExameAdicionar>
        {
            public PedidoExameValidation()
            {
                RuleFor(pe => pe.DataEmissao)
                    .NotEqual(new DateTime())
                    .NotNull()
                    .WithMessage("Data de Emissão deve ser informada");

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

                RuleFor(pe => pe.IdMedico)
                    .NotEqual(Guid.Empty)
                    .WithMessage("Médico solicitante deve ser informado");

            }

        }

    }

}