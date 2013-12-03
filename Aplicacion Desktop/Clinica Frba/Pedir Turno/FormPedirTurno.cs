using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Model;
using Clinica_Frba.Base;
using System.Data.SqlClient;
using Clinica_Frba.Interface;
using Clinica_Frba.Pedir_Turno;
using Clinica_Frba.Abm_de_Profesional;

namespace Clinica_Frba.NewFolder4
{
    public partial class FormPedirTurno : FormBase, IFInvocanteProfesional
    {
        public FormPedirTurno()
        {
            InitializeComponent();
        }

        private void btSeleccionarProfesional_Click(object sender, EventArgs e)
        {
            FormSearchProfesional frm = new FormSearchProfesional();
            frm.Accion = EActionSearch.SELECCION;
            frm.ShowDialog(this);
            
           
        }
        /// <summary>
        /// Completa el Data grip view de la izquierda con los dias que tiene en la agenda el usuarios
        /// </summary>
        public void FillDvgFechas()
        {
            String fechaCurrent = this.GetFechaConfig().ToString("dd-MM-yyyy");
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nroProfesional", ProfesionalCurrent.Numero));
            parametros.Add(new SqlParameter("fecha", fechaCurrent));
            DataTable dt = Turno.getRepository.listar("NN_NN.SP_LISTAR_AGENDA_DIAS", parametros);
            dgvFechas.DataSource = dt;
        }

      

        private void dgvFechas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void dgvFechas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow row = dgvFechas.Rows[e.RowIndex];
            try
            {
                // TODO La conversion de 0 al "disponibles" tendria que estar aca pero lo deje en la db
                // para usar el CASE de T_SQL
                if (row.Cells["ESTADO"].Value.ToString().Equals("DISPONIBLE"))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception xe)
            {
                System.Console.WriteLine("Ignoro expecion " + xe.ToString());
            }
        }

        private void dgvFechas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //TODO creo que no hacen falta estas columnas
            this.dgvFechas.Columns["fechaInicio"].Visible = false;
            this.dgvFechas.Columns["fechaFin"].Visible = false;
        }

        private void dgvFechas_DoubleClick(object sender, EventArgs e)
        {
            DateTime fecha = (DateTime)this.getObjectValueDataGrit(dgvFechas, "fecha");
            String fechaString = fecha.ToString("dd-MM-yyyy");
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_profesional", ProfesionalCurrent.Numero));
            parametros.Add(new SqlParameter("fecha", fechaString));
         
            this.dgvTurnosByDia.DataSource = Turno.getRepository.listar("NN_NN.SP_LISTA_TURNOS_LIBRE", parametros);


            DataTable dt = new DataTable();
            dt.Columns.Add("Estado");
            dt.Columns.Add("Descripcion");

            DataRow r = dt.NewRow();
            r["Estado"] = 0;
            r["Descripcion"] = "DISPONIBLE";
            dt.Rows.Add(r);
            r = dt.NewRow();
            r["Estado"] = 1;
            r["Descripcion"] = "NO DISPONIBLE";
            dt.Rows.Add(r);
            this.cbEstado.DataSource = dt;
            this.cbEstado.SelectedIndex = -1;
            this.cbEstado.DisplayMember = "Descripcion";
            this.cbEstado.Enabled = true;
            this.dtPFiltro.Enabled = true;
        }

        private void dgvTurnosByDia_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow row = dgvTurnosByDia.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ? (System.Drawing.Color.LightGray) : (System.Drawing.Color.DarkGray);
        }

        private void dgvTurnosByDia_DoubleClick(object sender, EventArgs e)
        {
            // Aca se llama al profesion
            List<SqlParameter> parametros = new List<SqlParameter>();
            Decimal numero = (Decimal )this.getObjectValueDataGrit(this.dgvTurnosByDia, "numero");
            parametros.Add(new SqlParameter("numero", numero));
            parametros.Add(new SqlParameter("@nro_afiliado", AfiliadoCurrent.NroAfiliado));
            parametros.Add(new SqlParameter("@nro_tipo_afiliado", AfiliadoCurrent.NroDiscriminador));

            Turno.getRepository.addModificar("[NN_NN].[SP_RESERVAR_TURNO]", parametros);
            MessageBox.Show("La operacion a terminado con exito");
        }

        private void FormPedirTurno_Load(object sender, EventArgs e)
        {
            this.FormBase_Load(sender, e);
            this.dtPFiltro.MinDate = this.GetFullFechaConfig();
            this.dtPFiltro.Value = this.GetFullFechaConfig();
        }

        #region Miembros de IFInvocanteProfesional

        bool IFInvocanteProfesional.seleccionarProfesional(Profesional selected)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("numero");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("mail");
            dt.Columns.Add("matricula");
            this.ProfesionalCurrent = selected;
            DataRow row = dt.NewRow();
            row["numero"] = ProfesionalCurrent.Numero;
            row["nombre"] = ProfesionalCurrent.Nombre;
            row["apellido"] = ProfesionalCurrent.Apellido;
            row["mail"] = ProfesionalCurrent.Mail;
            row["matricula"] = ProfesionalCurrent.Matricula;
            dt.Rows.Add(row);

            this.dgvProfesional.DataSource = dt;
            this.FillDvgFechas();
            
            return true;
        }

        #endregion
    }
}
