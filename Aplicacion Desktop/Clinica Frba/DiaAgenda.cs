using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;
using Clinica_Frba.NewFolder2;

namespace Clinica_Frba
{
    public partial class DiaAgenda : UserControl
    {
        // Como no me importa el dia seteo una fecha cualquiera
        private DateTime dtTimeF0;
        private DateTime dtTimeF1 = new DateTime(2012,12,12,0,0,0); 
        private short day = LUNES;
        private Form formAnfitrion;

        private static short lunes;
        private static short martes;
        private static short sabado;
        private static short miercoles;
        private static short jueves;
        private static short viernes;
        private static short domingo;
        private Boolean activo = false;


        public Boolean Activo
        {
            set { activo = value; }
            get { return activo; }
        }

        public static short LUNES
        {
            set { lunes = value; }
            get { return lunes; }
        }

        public static short MARTES
        {
            set { martes = value; }
            get { return martes; }
        }

        public static short MIERCOLES
        {
            set { miercoles = value; }
            get { return miercoles; }
        }

        public static short JUEVES
        {
            set { jueves = value; }
            get { return jueves; }
        }

        public static short VIERNES
        {
            set { viernes = value; }
            get { return viernes; }
        }

        public static short SABADO
        {
            set { sabado = value; }
            get { return sabado; }
        }

        public DiaAgenda()
        {
            InitializeComponent();
            
        }

        public Form FormAnfitrion
        {
            set { formAnfitrion = value; }
            get { return formAnfitrion; }
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
        public String ButtonSubtractText
        {
            set { this.btSubtract.Text = value; }
            get { return this.btSubtract.Text; }

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
            List<DataTimeWrapper> horasFraccion = new List<DataTimeWrapper>();
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
                horasFraccion.Add(new DataTimeWrapper(current));
                current = current.AddMinutes(30);
            }
            if (!final)
            {
                horasFraccion.Add(new DataTimeWrapper(current));
            }
            combo.DataSource = horasFraccion;
            combo.DisplayMember = "Time";
        }

      

        private void DiaAgenda_Load(object sender, EventArgs e)
        {
            this.Day = day;
        }

        

        

        private void btReset_Click(object sender, EventArgs e)
        {
            this.Day = LUNES;
        }

        private TimeSpan calcularHoras()
        {
            DateTime f1 = ((DataTimeWrapper)this.cbHoraFinal.SelectedItem).Date;
            DateTime f0 = ((DataTimeWrapper)this.cbHoraInicial.SelectedItem).Date;
            return f1.Subtract(f0);
        }

        private void actualizar()
        {
            int hr = calcularHoras().Hours;
            int min = calcularHoras().Minutes;
            lbCantHoras.Text = calcularHoras().Hours.ToString() + ((min == 30) ? (":30") : (""));
            Double turnos = calcularHoras().Hours / 0.5;
            lbCantTurnos.Text = (min == 30) ? ((turnos + 1).ToString()) : (turnos.ToString());
        }
        private void btDia_Click(object sender, EventArgs e)
        {
            int hr = calcularHoras().Hours;
            int min = calcularHoras().Minutes;
            lbCantHoras.Text = calcularHoras().Hours.ToString() + ((min == 30) ? (":30") : (""));
            Double turnos =  calcularHoras().Hours / 0.5;
            lbCantTurnos.Text = (min == 30) ? ((turnos + 1).ToString()) : (turnos.ToString());

            FormAgenda formAgenda = formAnfitrion as FormAgenda;
            if (formAgenda.AddDia(hr, min))
            {
                this.btDia.Visible = false;
                this.btSubtract.Visible = true;
                this.btReset.Visible = false;
                activo = true;
            }
        }

        private void btSubtract_Click(object sender, EventArgs e)
        {
            FormAgenda formAgenda = formAnfitrion as FormAgenda;
            int hr = calcularHoras().Hours;
            int min = calcularHoras().Minutes;
            formAgenda.SubtractDia(hr, min);
            this.btDia.Visible = true;
            this.btReset.Visible = true;
            this.btSubtract.Visible = false;
            activo = false;
        }

        private void cbHoraInicial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dtTimeF0 = ((DataTimeWrapper)this.cbHoraInicial.SelectedItem).Date;
            this.generarCombo(this.cbHoraFinal, false);
            actualizar();
        }

        private void cbHoraFinal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dtTimeF1 = ((DataTimeWrapper)this.cbHoraFinal.SelectedItem).Date;
            actualizar();
        }

        public String HoraFinalToString()
        {
            //return dtTimeF1.ToString(Properties.Settings.Default.fechaFormat);
            return ((DataTimeWrapper)this.cbHoraFinal.SelectedItem).Date.ToString(Properties.Settings.Default.fechaFormat);
        }
        public String HoraInicialToString()
        {
            return dtTimeF0.ToString(Properties.Settings.Default.fechaFormat);
        }
    }
}
