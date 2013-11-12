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
        private Rol rol;

        public FormAltaRol()
        {
            InitializeComponent();
        }

        public Rol Rol
        {
            set { rol = value; }
            get { return rol; }
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
            switch (Accion)
            {
                case EActionSearch.ALTA:
                    break;
                case EActionSearch.SELECCION:
                    
                    break;
                case EActionSearch.MODIFICACION:
                    tbNombre.Text = rol.Nombre;
                    foreach (string fun in rol.Funcionaliadades)
                    {
                        if (fun.Trim().Length > 0)
                        {
                            ckListFuncionalidad.SetItemChecked(
                                ckListFuncionalidad.Items.IndexOf(
                                    fun.Trim()
                                ), 
                                true
                            );
                        }
                    }
                    break;
            }
        }

        protected override void setControlsTag()
        {
            tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);
            ckListFuncionalidad.Tag = new Tag("funcionalidad", "funcionalidad", SqlDbType.Text);
        }

        protected override void ejecutarConsulta(List<SqlParameter> parametros)
        {
            // Aca voy hacer todo los errores creo
            base.ejecutarConsulta(parametros);
            try
            {
                String storeProcedure = String.Empty;
                switch (Accion)
                {
                    case EActionSearch.ALTA:
                        storeProcedure = "NN_NN.sp_add_rol";
                        break;
                    case EActionSearch.SELECCION:
                        break;
                    case EActionSearch.MODIFICACION:
                        SqlParameter param_id = new SqlParameter(
                            "id",
                            rol.Id
                        );
                        parametros.Add(param_id);
                        storeProcedure = "NN_NN.sp_modificar_rol";
                        break;
                }
                Rol.getRepository.addModificar(storeProcedure, parametros);
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
