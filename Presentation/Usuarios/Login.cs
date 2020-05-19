using App.Controllers;
using Infra.IoC;
using Presentation.Administradores;
using Presentation.Recepcionista;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Presentation.Usuarios
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private readonly UsuariosController _usuariosController;
        private readonly MedicosController medicosController;
        private readonly RecepcionistasController _recepcionistasController;

        public Login()
        {
            InitializeComponent();

            _usuariosController = DependenciesResolve.Resolve<UsuariosController>();
            medicosController = DependenciesResolve.Resolve<MedicosController>();
            _recepcionistasController = DependenciesResolve.Resolve<RecepcionistasController>();

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
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                //var usu = _usuariosController.ObterPorEmail(txtUsuario.Text);
                ////;
                ////var recepcionista = _recepcionistasController.ObterPorId(usu.Recepcionista.Id);
                //if (usu.Recepcionista.IdUsuario == usu.Id)
                //{
                //    new RecMenuPrincipal().Show();
                //    this.Hide();
                //}
                try
                {
                    var usuario = _usuariosController.Autenticar(txtUsuario.Text, txtSenha.Text);
                    new AdmMenuPrincipal().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtUsuario.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Campo Usuáio e Senha são obrigatórios");
                txtUsuario.Clear();
                txtSenha.Clear();
            }
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
    }
}
