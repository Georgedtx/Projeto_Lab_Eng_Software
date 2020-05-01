using Domain.Entities.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Exame
    {
        protected Exame() { }

        public Exame(string nome, string descricao)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public virtual ICollection<PedidoExame> PedidosExames { get; private set; }

        public ValidationResult Validation { get; set; }

        public bool IsValid()
        {
            Validation = new ExameValidation().Validate(this);
            return Validation.IsValid;
        }

        public void Atualizar(string novaDescricao)
        {
            Nome = novaDescricao;
        }
    }
}
