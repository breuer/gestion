using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clinica_Frba.Base;
using Clinica_Frba.Model;

namespace Clinica_Frba.Abm_de_Planes
{
    public partial class FormSearchPlanes : FormSearch
    {
        public FormSearchPlanes()
        {
            InitializeComponent();
        }

        
        protected override void search(List<SqlParameter> parametros)
        {
            dgvLista.DataSource = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_plan]", 
                parametros
            );
        }

        private void FormSearchPlanes_Load(object sender, EventArgs e)
        {
            tbDescripcion.Tag = new SqlParameter("descripcion", SqlDbType.Text);
        }

    }
}
