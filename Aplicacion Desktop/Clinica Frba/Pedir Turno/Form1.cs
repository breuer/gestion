using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Model;

namespace Clinica_Frba.NewFolder4
{
    public partial class Form1 : Form
    {
        private Profesional pro;

        public Profesional Pro
        {
            set { pro = value; }
            get { return pro; }
        }

        public Form1()
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

        public void FillDvgFechas()
        {

        }
    }
}
