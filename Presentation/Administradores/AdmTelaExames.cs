using Domain.Controllers;
using Domain.Entities;
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
    public partial class AdmTelaExames : Form
    {
        private readonly ExamesController _exameController;
        public AdmTelaExames()
        {
            InitializeComponent();
            _exameController = DependenciesResolve.Resolve<ExamesController>();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Medico_Click(object sender, EventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void BoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textNomeExame.Text != string.Empty))
            {
                if (textDescricao.Text != string.Empty)
                {
                    Exame exame = new Exame(textNomeExame.Text,textDescricao.Text);                
                    _exameController.Cadastrar(exame);
                    textNomeExame.Clear();
                    textDescricao.Clear();
                }
                else msgError("Digite a Descrição");
            }
            else msgError("Digite o nome");
        }

        private void msgError(String msg)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textNomeExame.Clear();
            textDescricao.Clear();
        }

        private void AdmTelaExames_Load(object sender, EventArgs e)
        {

        }
    }
}
