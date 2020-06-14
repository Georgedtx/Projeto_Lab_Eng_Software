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

namespace Presentation.Médico
{
    public partial class ListagemExames : Form
    {
        private readonly PedidosExamesController _pedidosExamesController;
        private readonly PacientesController _pacientesController;
        private readonly ExamesController _examesController;
        public ListagemExames()
        {
            _pedidosExamesController = DependenciesResolve.Resolve<PedidosExamesController>();
            _pacientesController = DependenciesResolve.Resolve<PacientesController>();
            _examesController = DependenciesResolve.Resolve<ExamesController>();
            InitializeComponent();
            AtualizarDataGrid();
        }

        private void AtualizarDataGrid()
        {
            var data2 = from info in _pedidosExamesController.ObterTodos()
                        orderby info.DataEmissao
                        select new
                        {
                            //Pedidos = info.Exame.Nome.ToString(),
                            //Hipótese = info.Hipotese,
                            Datalistagem = info.DataEmissao
                            
                        };
            ListaPedidosExame.DataSource = data2.ToList();
        }

        private void ListaPedidosExame_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var cpf;
            if (ListaPedidosExame.SelectedRows.Count > 0)
            {
                //var dataEmi = ListaPedidosExame.CurrentRow.Cells["Datalistagem"].Value.ToString();
                //var nomeExame = ListaPedidosExame.CurrentRow.Cells["Exame"].Value.ToString();
                //var nomePaciente = ListaPedidosExame.CurrentRow.Cells["Paciente"].Value.ToString();
                //var pacientes = _pedidosExamesController.ObterPedidosExamesDoPaciente(cpf);
                //var dataRea = pacientes.DataRealizacao;
                //var hipotese = pacientes.Hipotese;
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }
    }
}
