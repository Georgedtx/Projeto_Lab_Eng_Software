using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RegistroExame
    {
        protected RegistroExame() { }

        public RegistroExame(Guid idPedidoExame)
        {
            this.Id = Guid.NewGuid();
            this.Data = DateTime.Now;
            this.Laudo = "";
            this.Status = false;
            this.IdPedidoExame = idPedidoExame;
        }

        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Laudo { get; private set; }
        public bool Status { get; private set; }
        public Guid? IdDocente { get; private set; }
        public Guid? IdResidente { get; private set; }
        public Guid IdPedidoExame { get; private set; }

        public virtual ICollection<Arquivo> Arquivos { get; private set; }
        public virtual Docente Docente { get; private set; }
        public virtual PedidoExame PedidoExame { get; private set; }
        public virtual Residente Residente { get; private set; }

        public void EmitirLaudo(Guid idResidente, string laudo)
        {
            this.IdResidente = idResidente;
            this.Laudo = laudo;
        }

        public void ConfirmarLaudo(Guid idDocente, string laudo)
        {
            this.IdDocente = idDocente;
            this.Laudo = laudo;
            this.Status = true;
        }

    }
}
