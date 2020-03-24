using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public partial class Docente
    {
        protected Docente() { }

        public Docente(string titUniversitaria, int idMedico)
        {
            this.TitUniversitaria = titUniversitaria;
            this.IdMedico = idMedico;
        }

        public int Id { get; private set; }
        [Required]
        public string TitUniversitaria { get; private set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int IdMedico { get; private set; }

        public virtual Medico Medico { get; private set; }
        public virtual ICollection<RegistroExame> RegistrosExames { get; private set; }
    }
}
