using Domain.Entities;
using Domain.Interfaces.Repositories;
using DomainValidation.Interfaces.Specification;
using System.Linq;

namespace Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerEmailUnico : ISpecification<Usuario>
    {
        private readonly IRepository<Usuario> _repository;

        public UsuarioDeveTerEmailUnico(IRepository<Usuario> repository)
        {
            _repository = repository;
        }

        public bool IsSatisfiedBy(Usuario usuario)
        {
            return _repository.ObterTodos().Where(u => u.Email.ToUpper().Equals(usuario.Email.ToUpper())).FirstOrDefault() == null;
        }
    }
}
