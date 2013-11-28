using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clinica_Frba.Base;
using Clinica_Frba.Model;
using Clinica_Frba.Interface;

namespace Clinica_Frba.Abm_de_Planes
{
    public partial class FormSearchPlanes : FormSearch
    {
        public FormSearchPlanes()
        {
            InitializeComponent();
        }

        protected override void search(List<SqlParameter> parametros)
        {
            dgvLista.DataSource = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_plan]", 
                parametros
            );
        }

        private void FormSearchPlanes_Load(object sender, EventArgs e)
        {
            tbDescripcion.Tag = new Tag("descripcion", "descripcion", SqlDbType.Text);
        }

        protected override void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            PlanMedico plan = new PlanMedico();
            plan.Codigo = int.Parse(getValueDataGrit(dgvLista, "codigo"));
            plan.Descripcion = getValueDataGrit(dgvLista, "descripcion");

            if (Accion == EActionSearch.SELECCION)
            {
                IFInvocantePlan iDestino = this.Owner as IFInvocantePlan;
                if (iDestino != null)
                {
                    iDestino.seleccionarPlan(plan);
                    this.Close();
                }
            }
            else
            {
               // UpdateMicro frm = new UpdateMicro();
               // frm.Accion = ETipoAccion.MODIFICACION;
               // frm.Micro = dto;
               // frm.ShowDialog(this);
            }
        }


        public void setFiltro(Boolean enable)
        {
           

        }

        protected override void settingFiltroInicial()
        {
            this.ckBaja.Enabled = filtroEnable;
        }


       
       

    }
}
