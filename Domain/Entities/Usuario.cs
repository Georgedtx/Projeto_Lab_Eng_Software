using System;

namespace Domain.Entities
{
    public partial class Usuario
    {
        protected Usuario() { }

        public Usuario(string Email, string Senha)
        {
            this.Id = Guid.NewGuid();
            this.Email = Email;
            this.Senha = Senha;
        }

        public Guid Id { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Administrador Administrador { get; private set; }
        public virtual Medico Medico { get; private set; }
        public virtual Recepcionista Recepcionista { get; private set; }

        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }
    }
}
