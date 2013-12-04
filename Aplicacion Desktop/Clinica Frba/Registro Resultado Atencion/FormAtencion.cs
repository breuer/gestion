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
using System.Collections;
using Clinica_Frba.Base;
using Clinica_Frba.Registro_Resultado_Atencion;
using Clinica_Frba.Generar_Receta;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class FormAtencion : FormBase
    {
        int nroConsulta;

        public FormAtencion(int nroConsulta, int nroAfiliado)
        {
            InitializeComponent();
            this.nroConsulta = nroConsulta;
            tbNroAfiliado.Text = Convert.ToString(nroAfiliado);
            tbNroConsulta.Text = Convert.ToString(nroConsulta);
            dtpFechaConsulta.Value = GetFechaConfig();
            
        }

        private void btGenerarReceta_Click(object sender, EventArgs e)
        {
            FormReceta frm = new FormReceta(nroConsulta);
            frm.Show();
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {

        }
    }
}
