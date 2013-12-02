using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinica_Frba.Base;


namespace Clinica_Frba
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FormLogin frmLogin = new FormLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new FormMain());
            //}

            /*
            DataSession.idRol = 3;
            DataSession.nroAfiliado = "1";
            DataSession.nroDiscriminadorAfiliado = "1";
            DataSession.nroAfiliadoReceta = 3;
            Application.Run(new FormMain());
            */
            
        }
    }
}
