using System;

namespace Domain.Entities
{
    public partial class PedidoExame
    {
        protected PedidoExame() { }

        public PedidoExame(DateTime dataRealizacao, string hipotese, Guid idPaciente, Guid idExame, Guid idMedico)
        {
            this.Id = Guid.NewGuid();
            this.DataEmissao = DateTime.Now;
            this.DataRealizacao = dataRealizacao;
            this.Hipotese = hipotese;
            this.IdPaciente = idPaciente;
            this.IdExame = idExame;
            this.IdMedico = idMedico;
        }

        public Guid Id { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public DateTime DataRealizacao { get; private set; }
        public string Hipotese { get; private set; }
        public Guid IdPaciente { get; private set; }
        public Guid IdExame { get; private set; }
        public Guid IdMedico { get; private set; }

        public virtual Exame Exame { get; private set; }
        public virtual Medico Medico { get; private set; }
        public virtual Paciente Paciente { get; private set; }
        public virtual RegistroExame RegistroExame { get; private set; }

        public void Remarcar(DateTime novaData) => this.DataRealizacao = novaData;
    }
}
