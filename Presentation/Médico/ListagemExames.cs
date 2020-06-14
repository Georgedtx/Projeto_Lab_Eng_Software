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
        public ListagemExames()
        {
            _pedidosExamesController = DependenciesResolve.Resolve<PedidosExamesController>();
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
            if (ListaPedidosExame.SelectedRows.Count > 0)
            {

                var a = ListaPedidosExame.CurrentRow.Cells["Datalistagem"].Value.ToString();
                //CampoHipotese2.Text = ListaPedidosExame.CurrentRow.Cells["Hipótese"].Value.ToString();
                MessageBox.Show("aaaa",a);
            }
            else
            {
                MessageBox.Show("Selecione uma linha.");
            }
        }
    }
}
