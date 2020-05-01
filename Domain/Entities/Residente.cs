using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public partial class Residente
    {
        protected Residente() { }

        public Residente(int anoResidencia, Guid idMedico)
        {
            AnoResidencia = anoResidencia;
            IdMedico = idMedico;
        }

        public Guid Id { get; private set; }
        public int AnoResidencia { get; private set; }
        public Guid IdMedico { get; private set; }
        public virtual Medico Medico { get; private set; }
        public virtual ICollection<RegistroExame> RegistrosExames { get; private set; }
    }
}
