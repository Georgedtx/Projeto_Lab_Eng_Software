using Domain.Controllers;
using System;
using System.Windows.Forms;

namespace Presentation.Usuarios
{
    public partial class Login : Form
    {
        private readonly UsuariosController _usuariosController;

        public Login(UsuariosController usuariosController)
        {
            InitializeComponent();
            _usuariosController = usuariosController;
            //esconde barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
            //var menuPrincipal = new AdmMenuPrincipal();
            //menuPrincipal.Show();
        }

        void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
