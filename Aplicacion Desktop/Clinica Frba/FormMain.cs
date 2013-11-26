using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.NewFolder13;
using Clinica_Frba.Abm_de_Profesional;
using Clinica_Frba.NewFolder2;
using Clinica_Frba.NewFolder4;
using Clinica_Frba.Model;
using Clinica_Frba.Base;

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

            switch (DataSession.idRol)
            {
                case 0:
                    this.gbProfesional.Visible = false;
                    this.gbAfiliado.Visible = false;
                    break;
                case 1:
                    this.gbProfesional.Visible = false;
                    this.gb.Visible = false;
                    break;
                case 2:
                    this.gbAfiliado.Visible = false;
                    this.gb.Visible = false;
                    break;
            }
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
            btListarProfesional.Enabled = true;

            btAltaProfesional.Enabled = true;
            btRegistraAgenda.Enabled = true;
            btPedirTunro.Enabled = true;
            
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

        private void button6_Click(object sender, EventArgs e)
        {
            FormTestStoreProcedure frm = new FormTestStoreProcedure();
            frm.Show();
        }

        private void btListarProfesional_Click(object sender, EventArgs e)
        {
            FormSearchProfesional frm = new FormSearchProfesional();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormLinq frm = new FormLinq();
            frm.Show();
        }

        private void btRegistraAgenda_Click(object sender, EventArgs e)
        {
            FormAgenda frm = new FormAgenda();
            frm.Show();
        }

        private void btPedirTunro_Click(object sender, EventArgs e)
        {
            FormPedirTurno frm = new FormPedirTurno();
            frm.Show();
        }

        

      
    }
}
