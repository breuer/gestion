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
            btAltaAfiliado.Enabled = true;
        }

        private void btAltaAfiliado_Click(object sender, EventArgs e)
        {
            Abm_de_Afiliado.FormAltaFamiliar frm = new Abm_de_Afiliado.FormAltaFamiliar();
            frm.ShowDialog();
        }

      
    }
}
