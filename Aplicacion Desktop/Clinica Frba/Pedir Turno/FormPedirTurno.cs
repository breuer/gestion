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

namespace Clinica_Frba.NewFolder4
{
    public partial class FormPedirTurno : FormBase
    {
        private Profesional pro;

        public Profesional Pro
        {
            set { pro = value; }
            get { return pro; }
        }

        public FormPedirTurno()
        {
            InitializeComponent();
        }

        private void btSeleccionarProfesional_Click(object sender, EventArgs e)
        {
            //TODO DEBERIA LLAMAR AL SELECTOR DE P
            Pro = new Profesional(
                26,
                "Vera",
                "FORTUNATA",
                "fortunata_Vera@gmail.com",
                null
            );

            DataTable dt = new DataTable();

            dt.Columns.Add("numero");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("mail");
            dt.Columns.Add("matricula");

            DataRow row = dt.NewRow();
            row["numero"] = Pro.Numero;
            row["nombre"] = Pro.Nombre;
            row["apellido"] = Pro.Apellido;
            row["mail"] = Pro.Mail;
            row["matricula"] = Pro.Matricula;
            dt.Rows.Add(row);

            this.dgvProfesional.DataSource = dt;
            this.FillDvgFechas();
        }
        /// <summary>
        /// Completa el Data grip view de la izquierda con los dias que tiene en la agenda el usuarios
        /// </summary>
        public void FillDvgFechas()
        {
            String fechaCurrent = this.GetFechaConfig().ToString("dd-mm-yyyy");
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_profesional", Pro.Numero));
            parametros.Add(new SqlParameter("fecha", fechaCurrent));
            
            DataTable dt = Turno.getRepository.listar("NN_NN.SP_LISTAR_AGENDA_DIAS", parametros);
            }

        private void dgvFechas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MessageBox.Show("HOLA");
        }
    }
}
