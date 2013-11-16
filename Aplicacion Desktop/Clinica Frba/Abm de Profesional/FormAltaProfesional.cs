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
using Clinica_Frba.Validator;
using Clinica_Frba.Abm_de_Planes;
using Clinica_Frba.Abm_de_Especialidades_Medicas;
using Clinica_Frba.Interface;
using System.Data.SqlClient;

namespace Clinica_Frba.NewFolder13
{
    public partial class FormAltaProfesional : FormAlta, IFInvocanteEspecialidad
    {
        private Profesional profesional;
        private List<EspecialidaMedica> especialidadesSelected = new List<EspecialidaMedica>();

        public FormAltaProfesional()
        {
            InitializeComponent();
        }

        public Profesional Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

        
        

        protected override void loadControls()
        {
            cbTipo.DataSource = Afiliado.getRepository.getTipoDocumento();
            cbTipo.DisplayMember = "tipo";
        }

        protected override void setControlsTag()
        {
            tbApellido.Tag = new Tag("apellido", "apellido", SqlDbType.Text);
            tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);
            cbTipo.Tag = new Tag("tipo_documento", "tipo_documento", SqlDbType.Int);
            tbDni.Tag = new Tag("dni", "dni", SqlDbType.Int);
            tbTelefono.Tag = new Tag("telefono", "telefono", SqlDbType.Int);
            dtFechaNacimiento.Tag = new Tag("fechaNacimiento", "fechaNacimiento", SqlDbType.DateTime);
            gbSexo.Tag = new Tag("sexo", "sexo", SqlDbType.Bit);
            tbMatricula.Tag = new Tag("matricula", "matricula", SqlDbType.Int);
            tbDireccion.Tag = new Tag("direccion", "direccion", SqlDbType.Text);
            tbMail.Tag = new Tag("mail", "mail", SqlDbType.Text);
        }


        protected override String ValidarControls()
        {
            StringBuilder str = new StringBuilder();
            str.Append(ValidatorFrmProfesional.Validador(this.gbControl));
            if (dgvEspecialidadesMedicas.RowCount == 0)
            {
                str.Append("Especialidades: Debe elegir al menos una especialidad medica\n");
            }

            return  str.ToString();
        }



        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresssDigit(e);
        }
        private void tbDni_Leave(object sender, EventArgs e)
        {
            if (!"".Equals(tbDni.Text))
            {
                this.errorProvider.Clear();
                DataRow dataRowTipoDocumento = (DataRow) cbTipo.SelectedItem;
                DataTable dt = Profesional.getRepository.existeProfesional(tbDni.Text, dataRowTipoDocumento["codigo"].ToString());
                
                if (dt.Rows.Count != 0)
                {
                    this.errorProvider.SetError(tbDni, "Ya se encuentra registrado el profesional");
                    stError.Append("Dni: Ya se encuentra registrado el profesional\n");
                    this.btAccion.Enabled = false;
                }
                else
                {
                    // ErrorPrevio = true;
                }
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresssDigit(e);
        }

        private void tbMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPresssDigit(e);
        }

        private void tbMatricula_Leave(object sender, EventArgs e)
        {
            if (!"".Equals(tbMatricula.Text))
            {
                this.errorProvider.Clear();
                DataTable dt = Profesional.getRepository.existeMatricula(tbMatricula.Text);
                if (dt.Rows.Count != 0)
                {
                    this.errorProvider.SetError(tbMatricula, "Ya se encuentra registrado el profesional");
                    stError.Append("Matricula: Ya se encuentra registrado el profesional\n");
                    this.btAccion.Enabled = false;
                }
                else
                {
                    // ErrorPrevio = true;
                }
            }
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            FormSearchEspecialidad frm = new FormSearchEspecialidad();
            frm.Accion = EActionSearch.SELECCION;
            frm.Ejecutar = true;

            frm.Excluir = especialidadesSelected; frm.ShowDialog(this);
        }


        #region Miembros de IFInvocanteEspecialidad

        Boolean IFInvocanteEspecialidad.seleccionarEspecialidad(EspecialidaMedica selected)
        {
            if (especialidadesSelected.Contains(selected))
            {
                return false;
            }
            especialidadesSelected.Add(selected);
            BingDataGridView();
            return true;
        }

        #endregion

        private void BingDataGridView()
        {
            this.dgvEspecialidadesMedicas.AutoGenerateColumns = false;
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn collumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                HeaderText = "Codigo",
                Name = "Codigo",
                DataPropertyName = "Codigo" 
            };
            this.dgvEspecialidadesMedicas.Columns.Add(collumn);

            collumn = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                HeaderText = "Descripcion",
                Name = "Descripcion",
                DataPropertyName = "Descripcion" 
            };

            this.dgvEspecialidadesMedicas.Columns.Add(collumn);
            var list = new BindingList<EspecialidaMedica>(especialidadesSelected);
            this.dgvEspecialidadesMedicas.DataSource = list;
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
                       // Profesional.getRepository.
                        break;
                    case EActionSearch.SELECCION:
                        break;
                    case EActionSearch.MODIFICACION:
                        //SqlParameter param_id = new SqlParameter(
                        //    "id",
                        //    rol.Id
                        //);
                        //parametros.Add(param_id);
                        //storeProcedure = "NN_NN.sp_modificar_rol";
                        break;
                }
                Profesional.getRepository.addModificar(storeProcedure, parametros);
                MessageBox.Show("Operacion con exito");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
