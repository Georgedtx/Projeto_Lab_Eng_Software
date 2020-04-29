using App.Controllers;
using Domain.Entities;
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
    public partial class AdmTelaRecepcionista : Form
    {
        private readonly UsuariosController _usuariosController;
        private readonly RecepcionistasController _recepcionistasController;
        private int idUser;

        public AdmTelaRecepcionista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {

        }
        //txtendereço.focus();
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if ((textEndereco.Text != String.Empty) && (textBox1.Text != String.Empty))
            {
                Usuario user = new Usuario(textEndereco.Text, textBox1.Text);
                _usuariosController.Cadastrar(user);

                if (!user.Validation.IsValid)
                {
                    user.Validation.Erros.Select(erro => erro.Message);
                    textEndereco.Text = string.Empty;
                    textBox1.Text = string.Empty;
                }
                else
                {
                    idUser = user.Id;
                }
            }
        }

        private void AdmTelaRecepcionista_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textEndereco.Clear();
            BoxSenha.Clear();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != string.Empty))
            {
                //Recepcionista recepcionista = new Recepcionista(textBox3.Text, idUser);
                //_recepcionistasController.Cadastrar(recepcionista);
            }
            /*if (textBox1.Text != String.Empty)
            {
                Recepcionista recepcionista = new Recepcionista(textBox3.Text, idUser);
                _recepcionistasController.Cadastrar(recepcionista);

                if (!recepcionista.Validation.IsValid)
                {
                    recepcionista.Validation.Erros.Select(erro => erro.Message);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    idUser = user.Id;
                }
            }*/
        }
    }
}
