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
    public partial class FormCancelarAtencion : FormBase
    {
        public FormCancelarAtencion()
        {
            InitializeComponent();
        }

        private void FormCancelarAtencion_Load(object sender, EventArgs e)
        {
            base.FormBase_Load(sender, e);
            if (this.isAfiliado())
            {
                this.paAfiliado.Visible = true;
                this.btTodos.BackColor = Color.Red;
                this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO]");
            }
            else if (this.isProfesional())
            {
                
            }
            else
            {
            }
        }
         

        private DataTable FillTodos(String spName)
        {
            DataTable dtMisTurnos;
            List<SqlParameter> parametros = new List<SqlParameter>();

            if (this.isAfiliado())
            {
                parametros.Add(new SqlParameter("nroAfiliado", this.AfiliadoCurrent.NroAfiliado));
                parametros.Add(new SqlParameter("nroTipoAfiliado", this.AfiliadoCurrent.NroDiscriminador));
                dtMisTurnos = Turno.getRepository.listar(spName, parametros);
                return dtMisTurnos;
            }
            if (this.isProfesional())
            {
                // VER
            }
            return null;
        }

        

        private void PulsarBoton(Object sender, EventArgs e)
        {
            foreach (Control ctl in plBotones.Controls)
            {
                if (ctl == sender)
                    ctl.BackColor = Color.Red;
                else
                {
                    ctl.BackColor = plBotones.BackColor;
                }
            }

        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO]");
            PulsarBoton(sender, e);

        }
        private void btCancelados_Click(object sender, EventArgs e)
        {
            PulsarBoton(sender, e);
            this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO_CANCELADOS]");
        }

        private void btAsistidos_Click(object sender, EventArgs e)
        {
            PulsarBoton(sender, e);
            this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO_ASISTIDOS]");
        }

        private void btFuturos_Click(object sender, EventArgs e)
        {
            PulsarBoton(sender, e);
            this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO_CANCELADOS]");
        }

        private void btPerdidos_Click(object sender, EventArgs e)
        {
            PulsarBoton(sender, e);
            this.dgwTurnos.DataSource = FillTodos("[NN_NN].[SP_MIS_TURNOS_AFILIADO_CANCELADOS]");
        }
    }
}
