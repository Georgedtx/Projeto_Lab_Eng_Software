using Domain.Entities;
using DomainValidation.Interfaces.Specification;
using Domain.Validations.Usuarios;

namespace Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerSenhaValida : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return SenhaValidation.Validate(usuario.Senha);
        }
    }
}
