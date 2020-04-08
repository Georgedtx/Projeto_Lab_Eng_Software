using System;

namespace Domain.Entities
{
    public partial class Recepcionista
    {
        protected Recepcionista() { }

        public Recepcionista(string nome, DateTime nascimento, int idUsuario)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.IdUsuario = idUsuario;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public int IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }
    }
}
