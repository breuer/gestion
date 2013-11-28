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
using Clinica_Frba.Generales;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class FormAltaAfiliado : FormAlta, IFInvocantePlan, IFInvocanteFamiliar, IFInvocanteCalle
    {
        private Afiliado afiliado;
        private List<SqlParameter> conyuge;
        private List<List<SqlParameter>> familiar = new List<List<SqlParameter>>();
        private DataTable dtFamiliar;

        private PlanMedico planSeleccionado = new PlanMedico();

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
            tbNombre.Tag = new Tag("Nombre", "nombre", SqlDbType.Text);
            
            tbApellido.Tag = new Tag("Apellido", "apellido", SqlDbType.Text);

            cbEstadoCivil.DataSource = Afiliado.getRepository.getEstadoCivil();
            cbEstadoCivil.DisplayMember = "estadoCivil";
            cbEstadoCivil.Tag = new Tag("EstadoCivil", "estadoCivil", "codigo",  SqlDbType.Int);
            
            cbPlan.DataSource = PlanMedico.getRepository.getPlanes();
            cbPlan.DisplayMember = "descripcion";
            cbPlan.Tag = new Tag("Plan", "plan", "codigo", SqlDbType.Int);

            cbTipo.DataSource = Afiliado.getRepository.getTipoDocumento();
            cbTipo.DisplayMember = "tipo";
            cbTipo.Tag = new Tag("tipoDocumento", "tipoDocumento", "tipoDocumento", SqlDbType.Int);

            tbDni.Tag = new Tag("Documento", "documento", SqlDbType.Int);

            tbTelefono.Tag = new Tag("telefono", "telefono", SqlDbType.Int);

            tbDireccion.Tag = new Tag("direccion", "direccion", SqlDbType.Text);

            dtFechaNacimiento.Tag = new Tag("fecha", "fecha", SqlDbType.DateTime);

            tbMail.Tag = new Tag("email", "email", SqlDbType.Text);

            gbSexo.Tag = new Tag("sexo", "sexo", SqlDbType.Text);
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


                    dtFamiliar = new DataTable();
                    dtFamiliar.Columns.Add("Apellido");
                    dtFamiliar.Columns.Add("Nombre");
                    dtFamiliar.Columns.Add("Estado Civil");
                    //dt.Columns.Add("Plan");
                    dtFamiliar.Columns.Add("Tipo documento");
                    dtFamiliar.Columns.Add("Documento");
                    dtFamiliar.Columns.Add("Telefono");
                    dtFamiliar.Columns.Add("Direccion");
                    dtFamiliar.Columns.Add("Fecha");
                    dtFamiliar.Columns.Add("Email");
                    dtFamiliar.Columns.Add("Sexo");
                    
                    break;
                case EActionSearch.SELECCION:
                    cbPlan.Visible = false;
                    btSearchPlan.Visible = false;
                    lPlan.Visible = false;
                    dtFechaNacimiento.MaxDate = this.GetFechaConfig();
                    dtFechaNacimiento.Value = this.GetFechaConfig();
                    btAdd.Visible = true;
                    cbPlan.Enabled = false;
                    cbPlan.SelectedIndex = PlanSeleccionado.Codigo - 1;                   
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
                int i = int.Parse(((DataRowView)cbTipo.SelectedItem)["tipoDocumento"].ToString());
                DataTable dt = Afiliado.getRepository.existeAfiliado(tbDni.Text, i);
                
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


        private DataRow fill(List<SqlParameter> lst, DataRow row)
        {
            // NO QUEDO MUY LINDO
            foreach (SqlParameter param in lst)
            {
                switch (param.ParameterName)
                {
                    case "estadoCivil":
                        DataTable dtEstadoCivil = (DataTable)cbEstadoCivil.DataSource;
                        DataRow[] rowVetor = dtEstadoCivil.Select("codigo =" + param.Value);
                        row["Estado Civil"] = rowVetor[0]["estadoCivil"];
                        break;
                    case "sexo":
                        row["Sexo"] = ((Char)param.Value == 'F') ? ("Femenino") : ("Masculino");
                        break;
                    case "tipoDocumento":
                        DataTable dttd = (DataTable)cbTipo.DataSource;
                        DataRow[] rowDttd = dttd.Select("tipoDocumento =" + param.Value);
                        row["Tipo documento"] = rowDttd[0]["tipo"];
                        break;
                    default:
                        row[CultureInfo.InvariantCulture.TextInfo.ToTitleCase(param.ParameterName)] = param.Value;
                        break;
                }
            }
           
            return row;
        }

        public void seleccionarConyuge(List<SqlParameter> conyuge)
        {
            this.Conyuge = conyuge;
            if (this.dgvConyuge.RowCount > 0)
            {
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Estado Civil");
            //dt.Columns.Add("Plan");
            dt.Columns.Add("Tipo documento");
            dt.Columns.Add("Documento");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Email");
            dt.Columns.Add("Sexo");
            DataRow row = dt.NewRow();

            dt.Rows.Add(fill(conyuge, row));
            this.dgvConyuge.DataSource = dt; 
        }

        public void seleccionarFamiliar(List<SqlParameter> familiar)
        {
            this.Familiares.Add(familiar);
           
            DataRow row = dtFamiliar.NewRow();
            dtFamiliar.Rows.Add(fill(familiar, row));
            this.dgvFamiliares.DataSource = dtFamiliar;
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
            if (this.dgvConyuge.RowCount == 0)
            {
                FormAltaAfiliado frm = new FormAltaAfiliado();
                frm.Width = 354;
                frm.Height = 490;
                frm.isFamiliar = true;
                frm.btAdd.Text = addConyugeText;
                frm.Accion = EActionSearch.SELECCION;
                frm.ShowDialog(this);
                frm.PlanSeleccionado.Codigo = cbPlan.SelectedIndex;
                this.btQuitarConyuge.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ya se ha seleccionado el conyuge");
            }
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



        #region Miembros de IFInvocanteCalle

        public void seleccionar(string calleFull)
        {
            this.tbDireccion.Text = calleFull;
        }

        #endregion

        private void tbDireccion_Enter(object sender, EventArgs e)
        {
            FormIngresarFullCalle frm = new FormIngresarFullCalle();
            frm.ShowDialog(this);
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btAddFamiliar_Click(object sender, EventArgs e)
        {
            FormAltaAfiliado frm = new FormAltaAfiliado();
            frm.Width = 354;
            frm.Height = 490;
            frm.isFamiliar = true;
            frm.btAdd.Text = addFamiliarText;
            frm.Accion = EActionSearch.SELECCION;
            frm.ShowDialog(this);
        }

        private void cbQuitarConyuge_Click(object sender, EventArgs e)
        {
            this.dgvConyuge.Rows.Clear();
        }

        protected override void ejecutarConsulta(List<SqlParameter> parametros)
        {
            // Aca voy hacer todo los errores creo
            //base.ejecutarConsulta(parametros);
            try
            {
                String storeProcedure = String.Empty;
                switch (Accion)
                {
                    case EActionSearch.ALTA:
                        this.alta(parametros);
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
              

                MessageBox.Show("Operacion con exito");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void alta(List<SqlParameter> parametros)
        {
            if (conyuge == null || conyuge.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "No agregado a su conyuge, desea continuar?",
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (Familiares.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "No agregado a ningun familiar, desea continuar?",
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            SqlParameter sql = new SqlParameter("out", SqlDbType.Int);
            sql.Direction = ParameterDirection.ReturnValue;

            parametros.Add(sql);
            using (SqlConnection sqlConnection = Agenda.getRepository.OpenConnection())
            {
                sqlConnection.Open();
                SqlTransaction transaccion = sqlConnection.BeginTransaction(IsolationLevel.ReadCommitted);

                // agrego el usuario  
                List<SqlParameter> result = Agenda.getRepository.callProcedure(
                    "NN_NN.SP_ADD_AFILIADO",
                    parametros,
                    sqlConnection,
                    transaccion
                );
                Int32 idAfiliado = (Int32)result[0].Value;
                MessageBox.Show(idAfiliado.ToString());
                transaccion.Commit();
                // TODO el roolback deberia ponerlo aca en ves de hacer la llamada e callProcedure
            }
        }
    }
}
