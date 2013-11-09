using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.enableGroupBox(this.gbAbmRol, false);
            this.enableGroupBox(this.gbAbmUser, false);
            this.enableGroupBox(this.gbAbmAfiliado, false);
            this.enableGroupBox(this.gbAbmEspecialidad, false);
            this.enableGroupBox(this.gbAbmProfesional, false);
            this.enableGroupBox(this.gbPlan, false);

            this.enableGroupBox(this.gbEstadistico, false);
            this.enableGroupBox(this.gbAfiliado, false);
            this.enableGroupBox(this.gbProfesional, false);

        }

        private void enableGroupBox(GroupBox groupBox, Boolean enable)
        {
            foreach (Object obj in groupBox.Controls)
            {
                if (obj is Button)
                {
                    ((Button)obj).Enabled = enable;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btAltaRol.Enabled = true;
            btListarPlan.Enabled = true;
            btListarRol.Enabled = true;
            btAltaAfiliado.Enabled = true;
            
        }

        private void btAltaAfiliado_Click(object sender, EventArgs e)
        {
            Abm_de_Afiliado.FormAltaFamiliar frm = new Abm_de_Afiliado.FormAltaFamiliar();
            frm.ShowDialog();
        }

        private void btAltaRol_Click(object sender, EventArgs e)
        {
            Abm_de_Rol.FormAltaRol frm = new Clinica_Frba.Abm_de_Rol.FormAltaRol();
            frm.ShowDialog();
        }

        private void btListarRol_Click(object sender, EventArgs e)
        {
            Abm_de_Rol.FormSearchRol frm = new Clinica_Frba.Abm_de_Rol.FormSearchRol();
            frm.ShowDialog();
        }

        private void btListarPlan_Click(object sender, EventArgs e)
        {
            Abm_de_Planes.FormSearchPlanes frm = new Clinica_Frba.Abm_de_Planes.FormSearchPlanes();
            frm.ShowDialog();
        }

      
    }
}
