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
                string query = 
                    "SELECT TOP 1 ID_AFILIADO " +
                    "FROM NN_NN.USUARIO U " +
                    "WHERE U.USER_NAME = '" + username.Text + "' AND PASSWORD = '" + password.Text + "'";
                DataTable data = repo.listar(query);               
                if(data.Rows.Count != 0)               
                {
                    String idUsuario = Convert.ToString(data.Rows[0][0]);             
                    query = 
                        "SELECT  R.ID, R.NOMBRE " +
                        "FROM NN_NN.USUARIO_ROL UR " +
                        "JOIN NN_NN.ROL R " +
                        "ON UR.ID_ROL = R.ID " +
                        "WHERE UR.ID_USUARIO = " + idUsuario;
                    data = repo.listar(query);
                    if (data.Rows.Count > 1)
                    {
                        FormRol frmRol = new FormRol(data);
                        frmRol.ShowDialog(this);
                    }
                    if (data.Rows.Count == 1)
                    {
                        idRolSeleccionado = Convert.ToInt32(data.Rows[0][0]);
                    }
                    DataSession.idUsuario = idUsuario;
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
