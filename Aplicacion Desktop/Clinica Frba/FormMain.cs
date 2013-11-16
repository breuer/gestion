using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.NewFolder13;

namespace Clinica_Frba
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            this.gbAbmAfiliado.Visible = true;
            this.gbAbmEspecialidad.Visible = true;
            this.gbAbmProfesional.Visible = true;
            this.gbAbmAfiliado.Visible = true;

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

            btAltaProfesional.Enabled = true;
            
        }

        private void btAltaAfiliado_Click(object sender, EventArgs e)
        {
            Abm_de_Afiliado.FormAltaAfiliado frm = new Abm_de_Afiliado.FormAltaAfiliado();
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




        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btAltaProfesional_Click(object sender, EventArgs e)
        {
            FormAltaProfesional frm = new FormAltaProfesional();
            frm.Show();
        }

      
    }
}
