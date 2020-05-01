using System;

namespace App.ViewModels
{
    public class MedicoDetalhes
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Email { get; set; }
        
        public Guid IdDocente { get; set; }
        public string TitUniversitaria { get; set; }

        public Guid IdResidente { get; set; }
        public int AnoResidencia { get; set; }
    }
}
