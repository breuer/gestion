using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Model.Repository;
using System.Data.SqlClient;
using Clinica_Frba.Model;
using Clinica_Frba.Base;
using System.Security.Cryptography;

namespace Clinica_Frba
{
    public partial class FormLogin : Form, IFormLogin
    {
        public int idRolSeleccionado;

        public FormLogin()
        {
            InitializeComponent();
        }

        public void seleccionarRol(int idRol)
        {
            idRolSeleccionado = idRol;
        }
        public static string GenerarSHA256(string texto)
        {
            SHA256 sha256 = SHA256CryptoServiceProvider.Create();
            Byte[] hash = sha256.ComputeHash(ASCIIEncoding.Default.GetBytes(texto));
            StringBuilder cadena = new StringBuilder();
            foreach (byte xD in hash)
            {
                cadena.AppendFormat("{0:x2}", xD);
            }
            return cadena.ToString();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (username.Text != "" & password.Text != "")
            {
                Repository repo = new Repository();
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("username", username.Text));
                parametros.Add(new SqlParameter("password", GenerarSHA256(password.Text)));             
                DataTable dataUsuario = repo.listar("NN_NN.SP_LOGIN", parametros);                         
                if (dataUsuario.Rows.Count != 0)               
                {           
                    parametros.Clear();
                    parametros.Add(new SqlParameter("id_usuario", Convert.ToInt32(dataUsuario.Rows[0][0])));
                    DataTable dataRol = repo.listar("NN_NN.SP_ROLES", parametros);
                    if (dataRol.Rows.Count > 1)
                    {
                        FormRol frmRol = new FormRol(dataRol);
                        frmRol.ShowDialog(this);
                    }
                    if (dataRol.Rows.Count == 1)
                    {
                        idRolSeleccionado = Convert.ToInt32(dataRol.Rows[0][0]);
                    }
                    DataSession.nroAfiliado = Convert.ToString(dataUsuario.Rows[0][1]);
                    DataSession.nroDiscriminadorAfiliado = Convert.ToString(dataUsuario.Rows[0][2]);
                    DataSession.nroProfesional = Convert.ToString(dataUsuario.Rows[0][3]);
                    DataSession.idRol = idRolSeleccionado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show("error password o usuario no validos");
                }
            }
            else 
            {
                MessageBox.Show("error campos vacios");
            }   
        }

        private void FormLogin2_Load(object sender, EventArgs e)
        {

        }

    }
}
