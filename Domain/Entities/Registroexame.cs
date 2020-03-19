using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RegistroExame
    {
        protected RegistroExame() { }

        public RegistroExame(int idPedidoExame)
        {
            this.Data = DateTime.Now;
            this.Laudo = "";
            this.Status = false;
            this.IdPedidoExame = idPedidoExame;
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Laudo { get; private set; }
        public bool Status { get; private set; }
        public int? IdDocente { get; private set; }
        public int? IdResidente { get; private set; }
        public int IdPedidoExame { get; private set; }

        public virtual ICollection<Arquivo> Arquivos { get; private set; }
        public virtual Docente Docente { get; private set; }
        public virtual PedidoExame PedidoExame { get; private set; }
        public virtual Residente Residente { get; private set; }

        public void EmitirLaudo(int idResidente, string laudo)
        {
            this.IdResidente = idResidente;
            this.Laudo = laudo;
        }

        public void ConfirmarLaudo(int idDocente, string laudo)
        {
            this.IdDocente = idDocente;
            this.Laudo = laudo;
            this.Status = true;
        }

    }
}
