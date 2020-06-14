using App.Controllers;
using Infra.IoC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class Novolaudo : Form
    {
        private readonly RegistrosExamesController _registrosExamesController;
        public Novolaudo()
        {
            _registrosExamesController = DependenciesResolve.Resolve<RegistrosExamesController>();
            InitializeComponent();
            AtualizarDataGrid();
        }
        private void AtualizarDataGrid()
        {
            //var data = from info in _registrosExamesController.
            //           orderby info.Nome
            //           select new
            //           {
            //               Nome = info.Nome
            //           };
            //listaExames.DataSource = data.ToList();
        }
        private void LimparCampos()
        {
            CampoNome.Clear();
            CampoData.Clear();
            CampoMedico.Clear();
            CampoRecomendacoes.Clear();
            CampoExame.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Emitir_Click(object sender, EventArgs e)
        {

            //_registrosExamesController.EmitirLaudo(CampoMedico.Text, IdExame, laudo);
            //MessageBox.Show("Laudo emitido com sucesso");
            //LimparCampos();
            //AtualizarDataGrid();
        }
        private DateTime ObterData()
        {
            if (CampoData.Text.Length == 10)
            {
                var dia = Convert.ToInt16(CampoData.Text.Substring(0, 2));
                var mes = Convert.ToInt16(CampoData.Text.Substring(3, 2));
                var ano = Convert.ToInt16(CampoData.Text.Substring(6, 4));

                return new DateTime(ano, mes, dia);
            }

            return new DateTime();
        }
    }
}
