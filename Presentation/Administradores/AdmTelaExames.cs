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
        private bool Editar = false;
        private Guid Id;

        public AdmTelaExames()
        {
            InitializeComponent();

            _exameController = DependenciesResolve.Resolve<ExamesController>();

            AtualizarDataGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(Editar == false)
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
            if(Editar == true)
            {
                try
                {

                    _exameController.AlterarDescricao(Id, txtDescricao.Text);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Exame Atualizado com sucesso");
                LimparCampos();
                AtualizarDataGrid();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listaExames.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNome.Text = listaExames.CurrentRow.Cells["Nome"].Value.ToString();
                string stringGuid = listaExames.CurrentRow.Cells["IdExames"].Value.ToString();
                Id = Guid.Parse(stringGuid);               
            }
            else
                MessageBox.Show("Selecione uma linha.");
        }

        private void AtualizarDataGrid()
        {
            var data = from info in _exameController.ObterTodos()
                       orderby info.Nome
                       select new
                       {
                           Nome = info.Nome,
                           Id = info.Id
                       };
            listaExames.DataSource = data.ToList();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            Editar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        
    }
}
