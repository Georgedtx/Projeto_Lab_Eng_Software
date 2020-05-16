using System;

namespace Domain.Relatorios
{
    public class Relatorio : EventArgs
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataRealizacao { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Exame { get; set; }
        public string Recomendacoes { get; set; }
    }
}
