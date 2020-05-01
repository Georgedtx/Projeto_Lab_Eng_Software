using System;

namespace Domain.Entities
{
    public partial class Recepcionista
    {
        protected Recepcionista() { }

        public Recepcionista(string nome, DateTime nascimento, Guid idUsuario)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.IdUsuario = idUsuario;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        
        public Guid IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }
    }
}
