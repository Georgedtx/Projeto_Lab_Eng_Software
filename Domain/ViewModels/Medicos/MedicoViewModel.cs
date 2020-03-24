using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels.Medicos
{
    public class MedicoViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(10)]
        public string Crm { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int IdUsuario { get; set; }

        [StringLength(10, MinimumLength = 6)]
        public string TitUniversitaria { get; set; }

        [DataType(DataType.Date)]
        public DateTime AnoResidencia { get; set; }
    }
}
