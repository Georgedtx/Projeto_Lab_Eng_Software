using App.Controllers;
using Domain.Entities;
using Domain.ViewModels.Medicos;
using Infra.IoC;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaMed : Form
    {
        private readonly MedicosController _medicosController;
        private readonly UsuariosController _usuariosController;
        int idUser;

        public AdmTelaMed()
        {
            InitializeComponent();
            _medicosController = DependenciesResolve.Resolve<MedicosController>();
            _usuariosController = DependenciesResolve.Resolve<UsuariosController>();
        }

        private void AdmTelaMed_Load_1(object sender, EventArgs e)
        {
            //MostrarMedico();
        }

        private void Medicos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = _medicosController.ObterTodos();
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

        private void BoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    
        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCRM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DocenteButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MostrarMedico()
        {
            //dataGridView1.DataSource = _medicosController.ObterTodos();
        }

        private void Cadastrar_Click_1(object sender, EventArgs e)
        {
            if ((textEndereco.Text != String.Empty) && (BoxSenha.Text != String.Empty))
            {
                Usuario user = new Usuario(textEndereco.Text, BoxSenha.Text);
                _usuariosController.Cadastrar(user);
                if (!user.Validation.IsValid)
                {
                    user.Validation.Erros.Select(erro => erro.Message);
                    textEndereco.Text = string.Empty;
                    BoxSenha.Text = string.Empty;
                }
                else
                {
                    idUser = user.Id;
                }
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if ((textNome.Text != string.Empty))
            {
                if (textCRM.Text != string.Empty)
                {
                    MedicoViewModel medico = new MedicoViewModel();
                    medico.Nome = textNome.Text;
                    medico.Crm = textCRM.Text;
                    medico.IdUsuario = idUser;
                    string dateInput = textNascimento.Text;
                    DateTime parsedDate = DateTime.Parse(dateInput);
                    medico.AnoResidencia = parsedDate;
                    medico.TitUniversitaria = TituloUni.Text;
                    _medicosController.Cadastrar(medico);
                    textNome.Clear();
                    textCRM.Clear();
                    textNascimento.Clear();
                    TituloUni.Text = string.Empty;
                }
                else msgError("Digite o CRM");
            }
            else msgError("Digite o nome");
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            textNome.Clear();
            textCRM.Clear();
            textNascimento.Clear();
            TituloUni.Text = string.Empty;
        }

        private void msgError(String msg)
        {

        }
        private void textEndereco_TextChanged_1(object sender, EventArgs e)
        {

        }       
    }
}
