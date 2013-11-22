using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Interface;
using Clinica_Frba.Base;
using Clinica_Frba.Model;
using System.Data.SqlClient;

namespace Clinica_Frba.NewFolder2
{
    public partial class FormAgenda : FormBase, IFInvocanteProfesional
    {
        private Profesional pro;
        private int horas = 0;
        private int minutos = 0;
        
        public Profesional Pro
        {
            set { pro = value; }
            get { return pro; }
        }

        public FormAgenda()
        {
            InitializeComponent();
        }



        #region Miembros de IFInvocanteProfesional

        bool IFInvocanteProfesional.seleccionarProfesional(Clinica_Frba.Model.Profesional selected)
        {
            throw new NotImplementedException();
        }

        #endregion
        /// <summary>
        /// Completa el cbDias con la maxima cantidad de dias y un minimo de 10 dias
        /// </summary>
        private int FillComboDias()
        {
            List<int> dias = new List<int>();
            for (int i = Properties.Settings.Default.duracionAgendaMin; i <= Properties.Settings.Default.duracionAgendaMax; i++)
            {
                dias.Add(i);
            }
            cbDias.DataSource = dias;
            cbDias.SelectedIndex = cbDias.Items.Count - 1;
            return Properties.Settings.Default.duracionAgendaMax;
        }
        /// <summary>
        /// Setea el combo fechaFinal en base a una cantidad de dias
        /// </summary>
        /// <param name="dias"></param>
        private void FillFechaFinal(int dias)
        {
            DateTime dateFinal = dtFechaDesde.Value.AddDays(dias);
            dtFechaFinal.Value = dateFinal;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            dtFechaDesde.Value = this.GetFechaConfig();
            this.FillFechaFinal(this.FillComboDias());

        }

        private void cbDias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FillFechaFinal((Int32)this.cbDias.SelectedItem);
        }

        private void habilitarDias()
        {
            DataTable dt = Agenda.getRepository.getDias();
            DiaAgenda.LUNES = short.Parse(dt.Rows[1][0].ToString());
            DiaAgenda.MARTES = short.Parse(dt.Rows[2][0].ToString());
            DiaAgenda.MIERCOLES = short.Parse(dt.Rows[3][0].ToString());
            DiaAgenda.JUEVES = short.Parse(dt.Rows[4][0].ToString());
            DiaAgenda.VIERNES = short.Parse(dt.Rows[5][0].ToString());
            DiaAgenda.SABADO = short.Parse(dt.Rows[6][0].ToString());

            this.diaLunes.Enabled = true;
            this.diaLunes.FormAnfitrion = this;
            this.diaMartes.Enabled = true;
            this.diaMartes.FormAnfitrion = this;
            this.diaMiercoles.Enabled = true;
            this.diaMiercoles.FormAnfitrion = this;
            this.diaJueves.Enabled = true;
            this.diaJueves.FormAnfitrion = this;
            this.diaViernes.Enabled = true;
            this.diaViernes.FormAnfitrion = this;
            this.diaSabado.Enabled = true;
            this.diaSabado.FormAnfitrion = this;

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
            habilitarDias();
        }

        public bool AddDia(int argHr, int argMin)
        {
            int hrAcu = horas;
            int minAcu = minutos;
            int aux = 0;

            hrAcu += argHr;
            minAcu += argMin;

            aux = minAcu / 60;
            if (aux == 1)
            {
                hrAcu += 1;
                minAcu = 0;
            }
            if (hrAcu > Properties.Settings.Default.horasSemanaMax || 
                (hrAcu == Properties.Settings.Default.horasSemanaMax && minAcu == 30))
            {

                StringBuilder st = new StringBuilder();
                st.Append("No se puede agregar el dia. Supera la cantidad de horas maximas: ");
                st.Append(Properties.Settings.Default.horasSemanaMax);
                DialogResult result = MessageBox.Show(
                   st.ToString(),
                   Application.ProductName,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );
                return false;
            }

            horas = hrAcu;
            minutos = minAcu;
            tbHorasTotal.Text = horas.ToString() + ":" + minutos.ToString();
            if (horas <= 0 && minutos <= 0)
            {
                btGenerar.Enabled = false;
            }
            else
            {
                btGenerar.Enabled = true;
            }
            return true;
        }

        public bool SubtractDia(int argHr, int argMin)
        {
            horas -= argHr;
            minutos -= argMin;

            if (minutos < 0)
            {
                minutos = 30;
                horas -= 1;
            }
            tbHorasTotal.Text = horas.ToString() + ":" + minutos.ToString();

            if (horas <= 0 && minutos <= 0)
            {
                btGenerar.Enabled = false;
            }
            else
            {
                btGenerar.Enabled = true;
            }
            return true;
        }

        private void dtFechaDesde_Leave(object sender, EventArgs e)
        {
            this.FillFechaFinal((Int32)this.cbDias.SelectedItem);
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            String fecha_f0 = dtFechaDesde.Value.ToString(Properties.Settings.Default.fechaFormat);
            String fecha_f1 = dtFechaFinal.Value.ToString(Properties.Settings.Default.fechaFormat);
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_profesional", Pro.Numero));
            parametros.Add(new SqlParameter("fecha_inicio", fecha_f0));
            parametros.Add(new SqlParameter("fecha_fin", fecha_f1));
            SqlParameter paramReturn = new SqlParameter(
                "return",
                SqlDbType.Decimal
            );
            paramReturn.Direction = ParameterDirection.ReturnValue;
            parametros.Add(paramReturn);
            using (SqlConnection sqlConnection = Agenda.getRepository.OpenConnection())
            {
                sqlConnection.Open();
                SqlTransaction transaccion = sqlConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                List<SqlParameter> paramOut = Agenda.getRepository.callProcedure(
                    "NN_NN.SP_ADD_AGENDA",
                    parametros,
                    sqlConnection,
                    transaccion
                );
                // Registro las especialidades
                Int32 id = (Int32)paramOut[0].Value;
                
                // TODO Quedo feo
                List<DiaAgenda> lstDias = new List<DiaAgenda>();
                lstDias.Add(diaLunes);
                lstDias.Add(diaMartes);
                lstDias.Add(diaMiercoles);
                lstDias.Add(diaJueves);
                lstDias.Add(diaViernes);
                lstDias.Add(diaSabado);

                foreach (DiaAgenda date in lstDias)
                {
                    if (date.Activo)
                    {
                        parametros = new List<SqlParameter>();
                        parametros.Add(new SqlParameter("nro_agenda", id));
                        parametros.Add(new SqlParameter("codigo_dia", date.Day));
                        parametros.Add(new SqlParameter("hora_fin", date.HoraFinalToString()));
                        parametros.Add(new SqlParameter("hora_inicio", date.HoraInicialToString()));
                        Agenda.getRepository.callProcedure(
                            "NN_NN.SP_ADD_DIA_ATENCION",
                            parametros,
                            sqlConnection,
                            transaccion
                        );
                    }
                    
                }

                transaccion.Commit();
                // TODO el roolback deberia ponerlo aca
            }
        }
    }
}
