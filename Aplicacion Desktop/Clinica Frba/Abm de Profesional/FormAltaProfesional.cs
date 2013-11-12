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

namespace Clinica_Frba.NewFolder13
{
    public partial class FormAltaProfesional : FormAlta
    {
        private Profesional profesional;

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
            cbTipo.Tag = new Tag("tipo_doc", "tipo", SqlDbType.Int);
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
            if (dgvEspecialidadesMedicas.RowCount != 0)
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
                DataTable dt = Afiliado.getRepository.existeAfiliado(tbDni.Text);

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

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            FormSearchPlanes frm = new FormSearchPlanes();
            frm.Accion = EActionSearch.SELECCION;
            frm.Ejecutar = true;
            frm.ShowDialog(this);
        }

    }
}
