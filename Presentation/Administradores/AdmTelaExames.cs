using App.Controllers;
using App.ExtensionsMethods;
using Domain.Entities;
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
            var exame = new Exame(txtNome.Text, txtDescricao.Text);
            
            var result = _exameController.Cadastrar(exame);

            if (!result.Validation.IsValid)
            {
                MessageBox.Show(result.Validation
                    .Errors.Select(v => v.ErrorMessage).Concatenar());

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
