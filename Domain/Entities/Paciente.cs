using Domain.Entities.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Paciente
    {
        protected Paciente() { }

        public Paciente(string cpf, string nome, string sexo, string cor, DateTime nascimento)
        {
            this.Id = Guid.NewGuid();
            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Cor = cor;
            this.Nascimento = nascimento;
        }

        public Guid Id { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public string Sexo { get; private set; }
        public string Cor { get; private set; }
        public DateTime Nascimento { get; private set; }
        public virtual ICollection<PedidoExame> PedidosExames { get; private set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new PacienteValidation().Validate(this);
            return Validation.IsValid;
        }
    }
}
