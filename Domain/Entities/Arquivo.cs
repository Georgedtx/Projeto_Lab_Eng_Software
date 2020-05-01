using System;

namespace Domain.Entities
{
    public class Arquivo
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Caminho { get; private set; }

        public Guid IdRegistroExame { get; private set; }
        public virtual RegistroExame RegistroExame { get; private set; }

        protected Arquivo() { }

        public Arquivo(string nome, string caminho, Guid idRegistro)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Caminho = caminho;
            IdRegistroExame = idRegistro;
        }
    }
}
