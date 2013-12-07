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
    public partial class FormCompraBonoFarmacia : FormBase
    {
        public FormCompraBonoFarmacia()
        {
            InitializeComponent();
        }

        private void btComprarBonosFarmacia_Click(object sender, EventArgs e)
        {
            Repository repo = new Repository();
     
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_afiliado", DataSession.afiliadoSession.NroAfiliado));
            parametros.Add(new SqlParameter("nro_tipo_afiliado", DataSession.afiliadoSession.NroDiscriminador));
            parametros.Add(new SqlParameter("fecha_compra", GetFechaConfig()));
            parametros.Add(new SqlParameter("cant", int.Parse(tbCantidadBonosFarmacia.Text)));
            repo.callProcedure("NN_NN.SP_BUY_CANT_BONO_FARMACIA", parametros);
            this.Close();
        }
    }
}
