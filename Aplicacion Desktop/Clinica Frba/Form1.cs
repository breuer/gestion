using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Clinica_Frba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = Properties.Settings.Default.fechaConfig;
        }

        private void btSearchPlanes_Click(object sender, EventArgs e)
        {
            Abm_de_Especialidades_Medicas.FormSearchEspecialidad frm = new Clinica_Frba.Abm_de_Especialidades_Medicas.FormSearchEspecialidad();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = Clinica_Frba.Model.PlanMedico.getRepository.listar("SELECT * FROM [NN_NN].[PLAN]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_de_Planes.FormSearchPlanes frm = new Clinica_Frba.Abm_de_Planes.FormSearchPlanes();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlParameter param = new SqlParameter("HOL", SqlDbType.Int);
            System.Console.WriteLine(param.SqlDbType == SqlDbType.Int);

            switch (param.SqlDbType)
            {
                case SqlDbType.Money:
                    System.Console.WriteLine("CERO");
                    break;
                case SqlDbType.Int:
                    System.Console.WriteLine("1CERO");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             tbFecha.Text =  Properties.Settings.Default.fechaFormat;
             dpFecha.Value = DateTime.ParseExact("02/12/13 18:37:58", "MM/dd/yy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private void btSacarPrefijo_Click(object sender, EventArgs e)
        {
            string[] words = tbInicial.Text.Split(':');
            tbFinal.Text = words[0];
            tbFinal2.Text = words[1];
        }

        private void btTestTime_Click(object sender, EventArgs e)
        {
            // = new DateTimePicker();
            this.dpFecha.Format = DateTimePickerFormat.Time;
            this.dpFecha.ShowUpDown = true;
         }

    }
}
