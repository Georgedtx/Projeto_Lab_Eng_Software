using Domain.Entities;
using FluentValidation;
using System;

namespace Domain.Entities.Validations
{
    public class PedidoExameValidation : AbstractValidator<PedidoExame>
    {
        public PedidoExameValidation()
        {
            RuleFor(pe => pe.DataEmissao)
                .NotNull()
                .WithMessage("Data de Emissão deve ser informada");

            RuleFor(pe => pe.DataRealizacao)
                .NotNull()
                .WithMessage("Data de Realização deve ser informada");

            RuleFor(pe => pe.DataEmissao)
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
