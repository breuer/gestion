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

namespace Clinica_Frba.Pedir_Turno
{
    public partial class FormSearchTurno : FormSearch
    {
        public FormSearchTurno()
        {
            InitializeComponent();
        }

        private void FormSearchTurno_Load(object sender, EventArgs e)
        {
            //TODO tendria que ser en base al ROL!!! Ver luego
            this.dtpFecha.Value = this.GetFechaConfig();
            this.dtpFecha.Tag = new Tag("fecha", "fecha", SqlDbType.Text);

            this.cbTipoCancelacion.DataSource = Turno.getRepository.fillCombo();
            this.cbTipoCancelacion.SelectedIndex = -1;
            this.cbTipoCancelacion.DisplayMember = "descripcion";
            this.cbTipoCancelacion.Tag = new Tag("tipoCancelacion", "tipoCancelacion", SqlDbType.Int);
            
            if (AfiliadoCurrent != null)
            { 
                // Si es habierto por un Afiliado
                lbTituloMain.Text = "Mis turnos";
                Ejecutar = true;
                this.tbAfiliado.Text = AfiliadoCurrent.ApellidoNombre;
                this.btSeleccionarAfiliado.Visible = false;

            }
            else if (ProfesionalCurrent != null)
            {
                // Si es habierto por un Profesional
                lbTituloMain.Text = "Mis turnos";
                Ejecutar = true;
                this.tbProfesional.Text = ProfesionalCurrent.ApellidoNombre;
                this.btSeleccionarProfesional.Visible = false;
            }
            else
            {
                lbTituloMain.Text = "Lista de turnos";
            }
        }
        /// <summary>
        /// Search: Ejecuta el StoreProcedure encargado de listar los turnos en base
        /// a la lista de parametros recibidas
        /// </summary>
        /// <param name="parametros">Lista de parametro del estore procedure</param>
        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            DataTable dt = PlanMedico.getRepository.listar(
                "[NN_NN].[SP_LISTAR_TURNO]",
                parametros
            );
            dgvLista.DataSource = dt;
        }
        /// <summary>
        /// settingFiltroInicial: Seteo los filtros inicialies
        /// </summary>
        protected override void settingFiltroInicial()
        {
            
        }
    }
}
