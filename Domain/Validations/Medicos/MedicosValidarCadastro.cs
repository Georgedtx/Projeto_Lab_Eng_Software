using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Specifications.Medicos;
using DomainValidation.Validation;

namespace Domain.Validations.Medicos
{
    public class MedicosValidarCadastro : Validator<Medico>
    {
        public MedicosValidarCadastro(IRepository<Medico> repository)
        {
            var crmDuplicado = new MedicoDeveTerCrmUnico(repository);

            base.Add("crmDuplicado", new Rule<Medico>(crmDuplicado, "Crm já cadastrado!"));
        }
    }
}
