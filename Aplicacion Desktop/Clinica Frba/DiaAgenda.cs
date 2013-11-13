using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class DiaAgenda : UserControl
    {
        // Como no me importa el dia seteo una fecha cualquiera
        private DateTime dtTimeF0;
        private DateTime dtTimeF1 = new DateTime(2012,12,12,0,0,0); 
        private short day = LUNES;

        public DiaAgenda()
        {
            InitializeComponent();
            
        }

        public String Titulo
        {
            set { this.gb.Text = value;}
            get { return this.gb.Text; }
        }

        public String ButtonText
        {
            set { this.btDia.Text = value; }
            get { return this.btDia.Text; } 
        }

        public short Day
        {
            set { 
                day = value;
                if (day == SABADO)
                {
                    dtTimeF0 = new DateTime(
                        2012, 
                        12, 
                        12, 
                        Properties.Settings.Default.diaSabadoF0, 
                        0, 
                        0
                    );
                    dtTimeF1 = new DateTime(
                        2012, 
                        12, 
                        12, 
                        Properties.Settings.Default.diaSabadoF1, 
                        0, 
                        0
                    );
                }
                else
                {
                    dtTimeF0 = new DateTime(
                        2012,
                        12,
                        12,
                        Properties.Settings.Default.diaHabilF0,
                        0,
                        0
                    );
                    dtTimeF1 = new DateTime(
                        2012,
                        12,
                        12,
                        Properties.Settings.Default.diaHabilF1,
                        0,
                        0
                    );
                }
                generarCombo(this.cbHoraInicial, true);
                generarCombo(this.cbHoraFinal, false);
            }
            get
            {
                return day; 
            }
        }


        private void generarCombo(ComboBox combo, Boolean final)
        {
            List<DateTime> horasFraccion = new List<DateTime>();
            DateTime current;
            if (final)
            {
                current = this.dtTimeF0;
            }
            else
            {
                current = this.dtTimeF0.AddMinutes(30);
            }
            while (!(current.Hour == this.dtTimeF1.Hour && this.dtTimeF1.Minute == current.Minute))
            {
                horasFraccion.Add(current);
                current = current.AddMinutes(30);
            }
            if (!final)
            {
                horasFraccion.Add(current);
            }
            combo.DataSource = horasFraccion;
        }

        public const short LUNES = 2;
        public const short MARTES = 3;
        public const short MIERCOLES = 4;
        public const short JUEVES = 5;
        public const short VIERNES = 6;
        public const short SABADO = 7;

        private void DiaAgenda_Load(object sender, EventArgs e)
        {
            this.Day = day;
        }

        private void cbHoraInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbHoraInicial_Leave(object sender, EventArgs e)
        {
            this.dtTimeF0 = (DateTime)this.cbHoraInicial.SelectedItem;
            this.generarCombo(this.cbHoraFinal, false);
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.Day = LUNES;
        }

        private TimeSpan calcularHoras()
        {
            TimeSpan tm = new TimeSpan();
        }

        
    }
}
