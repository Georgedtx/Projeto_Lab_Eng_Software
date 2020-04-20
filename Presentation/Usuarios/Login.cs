using App.Controllers;
using Infra.IoC;
using Presentation.Administradores;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Presentation.Usuarios
{
    public partial class Login : Form
    {
        private readonly UsuariosController _usuariosController;
        private readonly MedicosController medicosController;

        public Login()
        {
            InitializeComponent();
            _usuariosController = DependenciesResolve.Resolve<UsuariosController>();
            medicosController = DependenciesResolve.Resolve<MedicosController>();

            //esconde barra
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EntrarLogin_Click(object sender, EventArgs e)
        {
            if (caixaUserAdm.Text != string.Empty)
            {
                if (caixaSenhaAdm.Text != string.Empty)
                {
                    var validLogin = _usuariosController.Autenticar(caixaUserAdm.Text, caixaSenhaAdm.Text);
                    if (validLogin != null)
                    {
                        var mainMenu = new AdmMenuPrincipal();
                        mainMenu.Show();
                        this.Hide();
                    }
                    msgError("Nome de usuário ou senha digitados incorretos. \n Por favor tente novamente.");
                    caixaSenhaAdm.Clear();
                    caixaUserAdm.Focus();
                }
                else msgError("Digite a senha");
            }
            else msgError("Digite o usuário");
        }

        private void msgError(String msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
        }

        void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void caixaUserAdm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
