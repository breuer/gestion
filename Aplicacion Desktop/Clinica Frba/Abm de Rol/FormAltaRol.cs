using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;
using Clinica_Frba.Model;
using System.Data.SqlClient;
using Clinica_Frba.Validator;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class FormAltaRol : FormAlta
    {
        public FormAltaRol()
        {
            InitializeComponent();
        }

        protected override void btLimpiar_Click(object sender, EventArgs e)
        {
            base.btLimpiar_Click(sender, e);
            this.loadControls();
        }

 
        protected override void loadControls()
        {
            DataTable dt = Rol.getRepository.getFuncionalidades();
            ckListFuncionalidad.Items.Clear();
            foreach (DataRow row in dt.AsEnumerable())
            {
                ckListFuncionalidad.Items.Add(row.ItemArray[1]);
            }
        }

        protected override void setControlsTag()
        {
            tbNombre.Tag = new SqlParameter("nombre", SqlDbType.Text);
            ckListFuncionalidad.Tag = new SqlParameter("funcionalidad", SqlDbType.Text); ;
        }

        protected override void ejecutarConsulta(List<SqlParameter> parametros)
        {
            // Aca voy hacer todo los errores creo
            base.ejecutarConsulta(parametros);
            try
            {
                Rol.getRepository.addModificar("NN_NN.sp_add_rol", parametros);
                MessageBox.Show("Operacion con exito");
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        protected override String ValidarControls()
        {
            return ValidatorFrmRol.Validador(this.gbControl);
            
        }

    }
}
