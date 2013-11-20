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
using System.Globalization;
using Clinica_Frba.Validator;
using Clinica_Frba.Interface;
using Clinica_Frba.Abm_de_Planes;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class FormAltaAfiliado : FormAlta, IFInvocantePlan, IFInvocanteFamiliar
    {
        private Afiliado afiliado;
        private List<SqlParameter> conyuge;
        private List<List<SqlParameter>> familiar = new List<List<SqlParameter>>();

        private PlanMedico planSeleccionado;

        private Boolean isFamiliar;

        public FormAltaAfiliado()
        {
            InitializeComponent();
        }

        public Boolean IsFamiliar
        {
            set { isFamiliar = value; }
            get { return isFamiliar; }
        }

        public PlanMedico PlanSeleccionado
        {
            set { planSeleccionado =  value; }
            get { return planSeleccionado; }
        }
        public List<SqlParameter> Conyuge
        {
            get { return conyuge; }
            set { conyuge = value; }
        }
        public List<List<SqlParameter>> Familiares
        {
            get { return familiar; }
            set { familiar = value; }
        }


        public Afiliado Afiliado
        {
            set { afiliado = value; }
            get { return afiliado; }
        }

        protected override void settingFrm()
        {
           
        }
        protected override void setControlsTag()
        {
            cbEstadoCivil.DataSource = Afiliado.getRepository.getEstadoCivil();
            cbEstadoCivil.DisplayMember = "estadoCivil";

            cbEstadoCivil.Tag = new Tag("estadoCivil", "estadoCivil", SqlDbType.Text);

            cbPlan.DataSource = PlanMedico.getRepository.getPlanes();
            cbPlan.DisplayMember = "descripcion";
            cbPlan.Tag = new Tag("plan", "plan", SqlDbType.Int);

            cbTipo.Tag = new Tag("tipo", "tipo", SqlDbType.Text);

            tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);

            tbApellido.Tag = new Tag("apellido", "apellido", SqlDbType.Text);

            tbDni.Tag = new Tag("dni", "dni", SqlDbType.Int);

            tbTelefono.Tag = new Tag("telefono", "telefono", SqlDbType.Int);

            dtFechaNacimiento.Tag = new Tag("fechaNacimiento", "fechaNacimiento", SqlDbType.DateTime);
        }

        
        protected override void loadControls()
        {
            switch (Accion)
            {
                case EActionSearch.ALTA:
                    btAddConyuge.Enabled = true;
                    btAddFamiliar.Enabled = true;
                    DateTime today = this.GetFechaConfig();
                    this.dtFechaNacimiento.Value = today;
                    this.dtFechaNacimiento.MaxDate = today.AddYears(-18);
                    
                    
                    break;
                case EActionSearch.SELECCION:
                    cbPlan.Visible = false;
                    btSearchPlan.Visible = false;
                    lPlan.Visible = false;
                    dtFechaNacimiento.MaxDate = this.GetFechaConfig();
                    dtFechaNacimiento.Value = this.GetFechaConfig();
                    btAdd.Visible = true;

                    break;
                case EActionSearch.MODIFICACION:
                    /*tbNombre.Text = rol.Nombre;
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
                    }*/
                    break;
            }
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
                      /*  SqlParameter param_id = new SqlParameter(
                            "id",
                            rol.Id
                        );
                        parametros.Add(param_id);*/
                        storeProcedure = "NN_NN.sp_modificar_rol";
                        break;
                }
                Rol.getRepository.addModificar(storeProcedure, parametros);


                MessageBox.Show("Operacion con exito");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        protected override String ValidarControls()
        {
            stError.Append(ValidatorFrmAfiliado.Validador(this.gbControl));
            return stError.ToString();

        }
        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresssDigit(e);
        }
        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresssDigit(e);
        }

        private void tbDni_Leave(object sender, EventArgs e)
        {
            if (!"".Equals(tbDni.Text))
            {
                this.errorProvider.Clear();
                DataTable dt = Afiliado.getRepository.existeAfiliado(tbDni.Text);
                
                if (dt.Rows.Count != 0)
                {
                    this.errorProvider.SetError(tbDni, "Ya se encuentra registrado el cliente");
                    stError.Append("Dni: Ya se encuentra registrado el cliente\n");
                    this.btAccion.Enabled = false;
                }
                else
                {
                  // ErrorPrevio = true;
                }
            }
        }

  
        #region Miembros de IFInvocantePlan

        void IFInvocantePlan.seleccionarPlan(PlanMedico plan)
        {
            this.cbPlan.SelectedIndex = this.cbPlan.FindString(plan.Descripcion);
        }

        #endregion

        #region Miembros de IFInvocanteFamiliar

        public void seleccionarConyuge(List<SqlParameter> conyuge)
        {
            this.Conyuge = conyuge;
            DataTable dt = new DataTable();

            dt.Columns.Add("descripcion");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("estadoCivil");
            dt.Columns.Add("fechaNacimiento");
            dt.Columns.Add("dni");
            dt.Columns.Add("telefono");

            foreach (SqlParameter param in conyuge)
            {
                DataRow row = dt.NewRow();
                row[param.ParameterName] = param.Value.ToString();
            }
            this.dgvConyuge.DataSource = dt;
             
        }

        public void seleccionarFamiliar(List<SqlParameter> familiar)
        {
            this.Familiares.Add(familiar);
        }

        #endregion

        private void btSearchPlan_Click(object sender, EventArgs e)
        {
            FormSearchPlanes frm = new FormSearchPlanes();
            frm.Accion = EActionSearch.SELECCION;
            frm.FiltroEnable = true;
            frm.Ejecutar = true;
            frm.ShowDialog(this);
        }

        private void btAddConyuge_Click(object sender, EventArgs e)
        {
            FormAltaAfiliado frm = new FormAltaAfiliado();
            frm.Width = 354;
            frm.Height = 490;
            frm.isFamiliar = true;
            frm.btAdd.Text = addConyugeText;
            frm.Accion = EActionSearch.SELECCION;
            frm.ShowDialog(this);

        }
       
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            String mensaje = this.ValidarControls();
            if (mensaje != String.Empty)
            {
                MessageBox.Show(mensaje);
                stError = new StringBuilder();
                return;
            }

            List<SqlParameter> parametros = new List<SqlParameter>();
            this.crearConsulta(this.gbControl, parametros);
            
            IFInvocanteFamiliar iDestino = this.Owner as IFInvocanteFamiliar;
            if (iDestino != null)
            {
                if (btAdd.Text.Equals(addConyugeText))
                {
                    iDestino.seleccionarConyuge(parametros);
                }
                else if (btAdd.Text.Equals(addFamiliarText))
                {
                    iDestino.seleccionarFamiliar(parametros);
                } 
            }
            this.Close();
            
            
        }


        private const String addConyugeText = "Agregar conyuge";
        private const String addFamiliarText = "Agregar familiar";

       
    }
}
