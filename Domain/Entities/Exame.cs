using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Exame
    {
        protected Exame() { }

        public Exame(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public virtual ICollection<PedidoExame> PedidosExames { get; private set; }

        public void Atualizar(string novaDescricao)
        {
            Nome = novaDescricao;
        }
    }
}
