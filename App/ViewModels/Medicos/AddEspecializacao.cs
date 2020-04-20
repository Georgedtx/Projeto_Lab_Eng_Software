using System;

namespace App.ViewModels.Medicos
{
    public class AddEspecializacao
    {
        public DateTime AnoResidencia { get; set; }
        public string TitUniversitaria { get; private set; }
        public int IdMedico { get; private set; }
    }
}
