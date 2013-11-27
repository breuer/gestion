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

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (username.Text != "" & password.Text != "")
            {
                Repository repo = new Repository();
                string query = "SELECT TOP 1 ID_AFILIADO, ID_AFILIADO_DISCRIMINADOR, ID_PROFESIONAL " +
                    "FROM NN_NN.USUARIO " +
                    "WHERE USER_NAME = '" + username.Text + "' AND PASSWORD = '" + password.Text + "'";
                DataTable dataUsuario = repo.listar(query);
                if (dataUsuario.Rows.Count != 0)               
                {
                    string idAfiliado = Convert.ToString(dataUsuario.Rows[0][0]);
                    string idDiscriminadorAfiliado = Convert.ToString(dataUsuario.Rows[0][1]);
                    string idProfesional = Convert.ToString(dataUsuario.Rows[0][2]);
                    query = 
                        "SELECT  R.ID, R.NOMBRE " +
                        "FROM NN_NN.USUARIO_ROL UR " +
                        "JOIN NN_NN.ROL R " +
                        "ON UR.ID_ROL = R.ID " +
                        "WHERE UR.ID_USUARIO = " + idAfiliado;
                    DataTable dataRol = repo.listar(query);
                    if (dataRol.Rows.Count > 1)
                    {
                        FormRol frmRol = new FormRol(dataRol);
                        frmRol.ShowDialog(this);
                    }
                    if (dataUsuario.Rows.Count == 1)
                    {
                        idRolSeleccionado = Convert.ToInt32(dataRol.Rows[0][0]);
                    }
                    DataSession.nroAfiliado = idAfiliado;
                    DataSession.nroDiscriminadorAfiliado = idDiscriminadorAfiliado;
                    DataSession.nroProfesional = idProfesional;
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
