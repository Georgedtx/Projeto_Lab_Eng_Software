using Domain.Controllers;
using Infra.IoC;
using System;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaMed : Form
    {
        private readonly MedicosController _medicosController;
        private readonly UsuariosController _usuariosController;

        public AdmTelaMed()
        {
            InitializeComponent();
            _medicosController = DependenciesResolve.Resolve<MedicosController>();
            _usuariosController = DependenciesResolve.Resolve<UsuariosController>();
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

        private void Nascimento_Click(object sender, EventArgs e)
        {

        }

        private void ResidenteButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TituloUni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
