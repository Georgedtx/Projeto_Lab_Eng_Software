﻿using App.Controllers;
using App.ExtensionsMethods;
using App.ViewModels.Pacientes;
using FontAwesome.Sharp;
using Infra.IoC;
using Presentation.Usuarios;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Recepcionista

{
    public partial class RecMenuPrincipal : Form
    {
        // campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private readonly PacientesController _pacientesController;

        public RecMenuPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //esconde barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _pacientesController = DependenciesResolve.Resolve<PacientesController>();

            AtualizarDataGrid();
            AtualizarDataGrid2();
        }

        private void AtualizarDataGrid()
        {
            //listaPacientes.DataSource = _pacientesController.ObterTodos()
            //.Select(m => new { Nome = m.Nome });
            //listaPacientes2.DataSource = _pacientesController.ObterTodos()
            //.Select(m => new { Nome = m.Nome });
            var data = from info in _pacientesController.ObterTodos()
                       orderby info.Nome
                       select new
                       {
                           Nome = info.Nome
                       };
            listaPacientes.DataSource = data.ToList();
        }
        private void AtualizarDataGrid2()
        {

            //var data = from info in _pacientesController.ObterTodos()
            //           orderby info.Nome
            //           select new
            //           {
            //               Nome = info.Nome
            //           };
            //listaPacientes2.DataSource = data.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paciente = new PacienteAdicionar
            {
                Nome = CampoNome.Text,
                Cor = CampoCor.Text,
                Cpf = removerMascaraCPF(CampoCPF.Text),
                Sexo = CampoSexo.SelectedItem.ToString(),
                Nascimento = ObterDataNascimento()
            };

            var result = _pacientesController.Cadastrar(paciente);

            if (!result.IsValid)
            {
                MessageBox.Show(result.Errors.Select(v =>
                                v.ErrorMessage).Concatenar());
                return;
            }

            MessageBox.Show("Paciente cadastrado(a) com sucesso");
            LimparCampos();
            AtualizarDataGrid();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string campCPF = removerMascaraCPF(BuscarCPF.Text);
            if (campCPF != string.Empty)
            {
                try
                {
                    var paciente = _pacientesController.ObterPorCpf(campCPF);
                    CampoNome3.Text = paciente.Nome.ToString();
                    CampoSexo2.Text = paciente.Sexo;
                    CampoNasc2.Text = paciente.Nascimento.ToString();
                    CampoCor2.Text = paciente.Cor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite o CPF");
            }
            
        }
        private string removerMascaraCPF(string cpf)
        {
            if (cpf.Length == 14)
            {
                cpf = cpf.Remove(3, 1);
                cpf = cpf.Remove(6, 1);
                cpf = cpf.Remove(9, 1);
                return cpf;

            }
            else
            {
                cpf = string.Empty;
                return cpf;
            }
        }
        private DateTime ObterDataNascimento()
        {
            if (CampoNasc.Text.Length == 10)
            {
                var dia = Convert.ToInt16(CampoNasc.Text.Substring(0, 2));
                var mes = Convert.ToInt16(CampoNasc.Text.Substring(3, 2));
                var ano = Convert.ToInt16(CampoNasc.Text.Substring(6, 4));

                return new DateTime(ano, mes, dia);
            }

            return new DateTime();
        }

        private void LimparCampos()
        {
            CampoCPF.Clear();
            CampoNome.Clear();
            CampoNasc.Clear();
        }

        // estrutura
        private struct CorRGB
        {
            public static Color cor1 = Color.FromArgb(172, 126, 241);
            public static Color cor2 = Color.FromArgb(249, 118, 176);
            public static Color cor3 = Color.FromArgb(253, 138, 114);
            public static Color cor4 = Color.FromArgb(95, 77, 221);
            public static Color cor5 = Color.FromArgb(249, 88, 155);
            public static Color cor6 = Color.FromArgb(24, 161, 251);
        }

        // metodos
        private void ActivateButton(object senderBtn, Color cor)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = cor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = cor;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // borda esquerda butao
                leftBorderBtn.BackColor = cor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icone do filho atual
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = cor;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.BlueViolet;
            lblTitleChildForm.Text = "Home";
        }

        //logo
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        // funcao arrastar janela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void painelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            var mainMenu = new Login();
            mainMenu.Show();
            this.Hide();
        }

        private void Exames_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, CorRGB.cor6);
            //    OpenChildForm(new AdmTelaExames());
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroExamesPopUp reg = new RegistroExamesPopUp();
            //   reg.caixaStatus.Text =
            //   reg.caixaData.Mask =
            reg.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
