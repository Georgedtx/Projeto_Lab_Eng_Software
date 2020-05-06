using Infra.IoC;
using Presentation.Administradores;
using Presentation.Recepcionista;
using Presentation.Usuarios;
using System;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DependenciesResolve.Wire(Dependencies.Create());
            Application.Run(new RecMenuPrincipal());
        }
    }
}
