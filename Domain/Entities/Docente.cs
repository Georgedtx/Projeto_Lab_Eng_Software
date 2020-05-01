using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Docente
    {
        protected Docente() { }

        public Docente(string titUniversitaria, Guid idMedico)
        {
            this.Id = Guid.NewGuid();
            this.TitUniversitaria = titUniversitaria;
            this.IdMedico = idMedico;
        }

        public Guid Id { get; private set; }
        public string TitUniversitaria { get; private set; }

        public Guid IdMedico { get; private set; }
        public virtual Medico Medico { get; private set; }

        public virtual ICollection<RegistroExame> RegistrosExames { get; private set; }
    }
}
