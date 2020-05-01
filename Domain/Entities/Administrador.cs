using System;

namespace Domain.Entities
{
    public partial class Administrador
    {
        protected Administrador() { }

        public Administrador(string nome, Guid idUsuario)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.IdUsuario = idUsuario;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Guid IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }
    }
}
