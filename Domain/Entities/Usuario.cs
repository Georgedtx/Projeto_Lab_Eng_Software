using Domain.Validations.Usuarios;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Usuario
    {
        protected Usuario() { }

        public Usuario(string Email, string Senha)
        {
            this.Email = Email;
            this.Senha = Senha;
        }

        public int Id { get; private set; }

        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        public string Email { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 10)]
        public string Senha { get; set; }

        public DomainValidation.Validation.ValidationResult Validation { get; set; }

        public virtual Administrador Administrador { get; private set; }
        public virtual Medico Medico { get; private set; }
        public virtual Recepcionista Recepcionista { get; private set; }

        public void AlterarSenha(string novaSenha)
        {
            Senha = novaSenha;
        }

        public bool IsValid()
        {
            Validation = new UsuarioValidarDados().Validate(this);
            return Validation.IsValid;
        }
    }
}
