using Domain.Controllers;
using Infra.IoC;
using System;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaMed : Form
    {
        private readonly MedicosController _medicosController;

        public AdmTelaMed()
        {
            InitializeComponent();
            _medicosController = DependenciesResolve.Resolve<MedicosController>();
        }

        private void Medicos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovoMedico_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
