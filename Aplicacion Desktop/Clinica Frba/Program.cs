using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinica_Frba.Base;
using Clinica_Frba.Model;


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
            
            /*
            FormLogin frmLogin = new FormLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }*/

            DataSession.idRol = 1;
            DataSession.nroAfiliado = "7149";
            DataSession.nroDiscriminadorAfiliado = "1";
            DataSession.nroAfiliadoReceta = 3;
            DataSession.nroConsulta = 108318;
            DataSession.profesionalSession = new Profesional(1, "apellido", "nombre", "email", 1);
            DataSession.afiliadoSession = new Afiliado();
            DataSession.afiliadoSession.NroAfiliado = 7434;
            DataSession.afiliadoSession.NroDiscriminador = 1;
            Application.Run(new FormMain());
  
        }
    }
}
