using System;

namespace App.ViewModels
{
    public class MedicoDetalhes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Email { get; set; }
        
        public int IdDocente { get; set; }
        public string TitUniversitaria { get; set; }

        public int IdResidente { get; set; }
        public DateTime AnoResidencia { get; set; }
    }
}
