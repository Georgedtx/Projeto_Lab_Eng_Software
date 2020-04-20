using Domain.Entities;
using Domain.Interfaces.Repositories;
using DomainValidation.Interfaces.Specification;
using System.Linq;

namespace Domain.Specifications.Medicos
{
    public class MedicoDeveTerCrmUnico : ISpecification<Medico>
    {
        private readonly IRepository<Medico> _repository;

        public MedicoDeveTerCrmUnico(IRepository<Medico> repository)
        {
            _repository = repository;
        }

        public bool IsSatisfiedBy(Medico medico)
        {
            return _repository.ObterTodos().Where(m => m.Crm.Equals(medico.Crm)).FirstOrDefault() == null;
        }
    }
}
