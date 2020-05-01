using App.Controllers;
using App.ExtensionsMethods;
using App.ViewModels.Exames;
using Infra.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmTelaExames : Form
    {
        private readonly ExamesController _exameController;

        public AdmTelaExames()
        {
            InitializeComponent();

            _exameController = DependenciesResolve.Resolve<ExamesController>();

            AtualizarDataGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var exame = new ExameAdicionar { Nome = txtNome.Text, Descricao = txtDescricao.Text };

            var result = _exameController.Cadastrar(exame);

            if (!result.IsValid)
            {
                MessageBox.Show(result.Errors.Select(v => v.ErrorMessage).Concatenar());
                return;
            }

            MessageBox.Show("Exame adicionado com sucesso");
            LimparCampos();
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            //listaExames.DataSource = _exameController.ObterTodos()
            //    .Select(e => new { Id = e.Id, Nome = e.Nome });
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
