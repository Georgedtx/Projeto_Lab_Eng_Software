using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Medico
    {
        protected Medico() { }

        public Medico(string nome, string crm, Guid idUsuario)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Crm = crm;
            this.IdUsuario = idUsuario;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Crm { get; private set; }
        
        public Guid IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }

        public virtual Docente Docente { get; private set; }
        public virtual Residente Residente { get; private set; }
        public virtual ICollection<PedidoExame> PedidosExames { get; private set; }
    }
}
