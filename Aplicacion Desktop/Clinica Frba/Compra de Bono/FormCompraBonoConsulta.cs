using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Model.Repository;
using System.Data.SqlClient;
using Clinica_Frba.Base;

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class FormCompraBonoConsulta : FormBase
    {
        public FormCompraBonoConsulta()
        {
            InitializeComponent();
        }


        private void btComprarBonosConsulta_Click(object sender, EventArgs e)
        {
            Repository repo = new Repository();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_afiliado", DataSession.afiliadoSession.NroAfiliado));
            parametros.Add(new SqlParameter("nro_tipo_afiliado", DataSession.afiliadoSession.NroDiscriminador));
            parametros.Add(new SqlParameter("fecha_compra", GetFechaConfig()));
            parametros.Add(new SqlParameter("cant", int.Parse(tbCantidadBonosConsulta.Text)));
            repo.callProcedure("NN_NN.SP_BUY_CANT_BONO_CONSULTA", parametros);
            this.Close();
        }

        private void tbCantidadBonosConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
