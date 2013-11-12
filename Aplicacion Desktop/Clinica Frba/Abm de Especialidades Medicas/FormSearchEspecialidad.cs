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


namespace Clinica_Frba.Abm_de_Especialidades_Medicas
{
    public partial class FormSearchEspecialidad : FormSearch
    {
        
        public FormSearchEspecialidad()
        {
            InitializeComponent();
        }

        private void FormSearchEspecialidad_Load(object sender, EventArgs e)
        {
            cbTipoEspecialidad.DataSource = EspecialidaMedica.getRepository.getTipo();
            cbTipoEspecialidad.DisplayMember = "codigo";
            cbTipoEspecialidad.SelectedIndex = -1;
            SqlParameter sqlParam = new SqlParameter("codigoTipo", SqlDbType.Int);
            cbTipoEspecialidad.Tag = sqlParam;

            sqlParam = new SqlParameter("codigo", SqlDbType.Int);
            tbCodigo.Tag = sqlParam;

            sqlParam = new SqlParameter("descripcion", SqlDbType.Text);
            tbDescripcion.Tag = sqlParam;
 
        }



        protected override void fill()
        {
            MessageBox.Show("HOLLLL");
        }
        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            dgvLista.DataSource = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_especialidad]", 
                parametros
            );
        }

    
    }
}
