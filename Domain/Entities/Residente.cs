using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Residente
    {
        protected Residente() { }

        public Residente(DateTime anoResidencia, int idMedico)
        {
            AnoResidencia = anoResidencia;
            IdMedico = idMedico;
        }

        public int Id { get; private set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime AnoResidencia { get; private set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int IdMedico { get; private set; }

        public virtual Medico Medico { get; private set; }
        public virtual ICollection<RegistroExame> RegistrosExames { get; private set; }
    }
}
