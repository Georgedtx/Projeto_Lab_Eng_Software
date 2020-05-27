using FontAwesome.Sharp;
using Presentation.Usuarios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Administradores
{
    public partial class AdmMenuPrincipal : Form
    {
        // campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public AdmMenuPrincipal()
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
        }
        public AdmMenuPrincipal(string nome)
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
            NomeTelaPrincipal.Text = nome;
        }

        // metodos
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Teal;
                currentBtn.ForeColor = Color.DarkSlateGray;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.DarkSlateGray;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // borda esquerda butao
                leftBorderBtn.BackColor = Color.DarkSlateGray;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.LightSeaGreen;
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
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Home";
        }

        private void Administrador_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdmTelaAdministrador());
        }

        private void Medico_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdmTelaMed());
        }

        private void Recepcionista_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdmTelaRecepcionista());
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
            ActivateButton(sender);
            OpenChildForm(new AdmTelaExames());
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdmGerenciarUsers());
        }
    }
}
