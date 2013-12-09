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

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class FormCancelar : FormBase
    {
        public Boolean isRango = false;
        public Decimal idTurno = 0;
        public DateTime fecha;

        public FormCancelar()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            if (tbMotivo.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro de cancelar la operacion?",
                    "Cancelar la operacion",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (tbMotivo.Text.Length < 0)
            {
                MessageBox.Show(
                    "Debe ingresar un comentario cuando realiza una cancelacion.",
                    "Aviso"
                );
            }
            else
            {
                // Cancelacion por parte del Profesional puede ser por rango o por turno
                if (this.AfiliadoCurrent != null)
                {
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("idTurno", idTurno));
                    parametros.Add(new SqlParameter(
                        "date", 
                        fecha.ToString(Properties.Settings.Default.fechaFormat)
                    ));
                    parametros.Add(new SqlParameter(
                        "dateNow", 
                        this.GetFullFechaConfig().ToString(Properties.Settings.Default.fechaFormat)
                    ));
                    parametros.Add(new SqlParameter("motivo", tbMotivo.Text));
                    Turno.getRepository.callProcedure(
                        "[NN_NN].[SP_CANCELAR_TURNO_BY_AFILIADO]",
                        parametros
                    );
                }
                else
                {
                    if (isRango == false)
                    {
                        List<SqlParameter> parametros = new List<SqlParameter>();
                        parametros.Add(new SqlParameter("idTurno", idTurno));
                        parametros.Add(new SqlParameter(
                            "date",
                            fecha.ToString(Properties.Settings.Default.fechaFormat)
                        ));
                        parametros.Add(new SqlParameter(
                            "dateNow",
                            this.GetFullFechaConfig().ToString(Properties.Settings.Default.fechaFormat)
                        ));
                        parametros.Add(new SqlParameter("motivo", tbMotivo.Text));
                        Turno.getRepository.callProcedure(
                            "[NN_NN].[SP_CANCELAR_TURNO_BY_PROFESIONAL]",
                            parametros
                        );
                    }
                    else
                    {
                        List<SqlParameter> parametros = new List<SqlParameter>();
                        parametros.Add(new SqlParameter("idTurno", idTurno));
                        parametros.Add(new SqlParameter(
                            "dateF0",
                            dpF0.Value.ToString(Properties.Settings.Default.fechaFormat)
                        ));
                        parametros.Add(new SqlParameter(
                            "dateF1",
                            dpF1.Value.ToString(Properties.Settings.Default.fechaFormat)
                        ));
                        parametros.Add(new SqlParameter(
                            "dateNow",
                            this.GetFullFechaConfig().ToString(Properties.Settings.Default.fechaFormat)
                        ));
                        parametros.Add(new SqlParameter("motivo", tbMotivo.Text));
                        Turno.getRepository.callProcedure(
                            "[NN_NN].[SP_CANCELAR_RANGO_TURNO_BY_PROFESIONAL]",
                            parametros
                        );
                    }

                }
            }

        }

        private void FormCancelar_Load(object sender, EventArgs e)
        {
            base.FormBase_Load(sender, e);

            if (this.ProfesionalCurrent != null)
            {
                dpF0.Visible = true;
                dpF1.Visible = true;
            }
            else
            {
                dpF0.Visible = false;
                dpF1.Visible = false;
            }
        }
    }
}
