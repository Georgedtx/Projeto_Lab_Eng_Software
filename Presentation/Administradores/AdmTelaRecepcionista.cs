using App.Controllers;
using App.ExtensionsMethods;
using App.ViewModels.Recepcionistas;
using Infra.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaRecepcionista : Form
    {
        private readonly RecepcionistasController _recepcionistasController;

        public AdmTelaRecepcionista()
        {
            InitializeComponent();

            _recepcionistasController = DependenciesResolve.Resolve<RecepcionistasController>();
            
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            //listaRecepcionista.DataSource = _recepcionistasController.ObterTodos()
                                       //.Select(m => new { Nome = m.Nome });
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            var recepcionista = new RecepcionistaAdicionar
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                RepetirSenha = txtMesmaSenha.Text,
                Nome = txtNome.Text,
                Nascimento = ObterDataNascimento()
            };

            var result = _recepcionistasController.Cadastrar(recepcionista);

            if (!result.IsValid)
            {
                MessageBox.Show(result.Errors.Select(v =>
                                v.ErrorMessage).Concatenar());

                return;
            }

            MessageBox.Show("Recepcionista cadastrado(a) com sucesso");
            LimparCampos();
            AtualizarDataGrid();
        }

        private DateTime ObterDataNascimento()
        {
            if (txtNascimento.Text.Length == 10)
            {
                var dia = Convert.ToInt16(txtNascimento.Text.Substring(0, 2));
                var mes = Convert.ToInt16(txtNascimento.Text.Substring(3, 2));
                var ano = Convert.ToInt16(txtNascimento.Text.Substring(6, 4));

                return new DateTime(ano, mes, dia);
            }

            return new DateTime();
        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtMesmaSenha.Clear();
            txtNome.Clear();
            txtNascimento.Clear();
        }
    }
}
