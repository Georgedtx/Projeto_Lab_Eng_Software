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
            //var data2 = from info in _pedidosExamesController.
            //            orderby info.Exame
            //            select new
            //            {
            //                //Pedidos = info.Exame.Nome.ToString(),
            //                Hipótese = info.Hipotese
            //            };
            //ListaPedidosExame.DataSource = data2.ToList();
        }
    }
}
