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

namespace Clinica_Frba
{
    public partial class FormRol : Form
    {
        public FormRol(DataTable data)
        {
            InitializeComponent();
            cbRol.DataSource = data;
            cbRol.DisplayMember = "NOMBRE";

        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            int rol = cbRol.SelectedIndex;
            IFormLogin iDestino = this.Owner as IFormLogin;
            if (iDestino != null)
            {
                iDestino.seleccionarRol(rol);
                this.Close();
            }
        }

        private void FormRol_Load(object sender, EventArgs e)
        {

        }            
    }
}
