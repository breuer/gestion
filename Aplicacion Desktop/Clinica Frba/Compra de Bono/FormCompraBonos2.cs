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

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class FormCompraBonos2 : Form
    {
        int nro;
        int nroTipo;
        int cantBonosConsulta;
        int cantBonosFarmacia;

        public FormCompraBonos2()
        {
            InitializeComponent();
        }

        private void FormCompraBonos2_Load(object sender, EventArgs e)
        {

        }
            
        private void inNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            nro = int.Parse(inNroAfiliado.Text);
        }

        private void inNroTipoAfiliado_TextChanged(object sender, EventArgs e)
        {
            nroTipo = int.Parse(inNroTipoAfiliado.Text);
        }

        private void inCantBonosConsulta_TextChanged(object sender, EventArgs e)
        {
            cantBonosConsulta = int.Parse(inCantBonosConsulta.Text);
        }

        private void inCantBonosFarmacia_TextChanged(object sender, EventArgs e)
        {
            cantBonosFarmacia = int.Parse(inCantBonosFarmacia.Text);
        }

        private void inputCompra_Click(object sender, EventArgs e)
        {

            Repository repo = new Repository();
            List<SqlParameter> parametrosC = new List<SqlParameter>();
            parametrosC.Add(new SqlParameter("nro_afiliado", nro));
            parametrosC.Add(new SqlParameter("nro_tipo_afiliado", nroTipo));
            parametrosC.Add(new SqlParameter("cant", cantBonosConsulta));
            repo.callProcedure("NN_NN.SP_BUY_CANT_BONO_CONSULTA", parametrosC);

            List<SqlParameter> parametrosF = new List<SqlParameter>();
            parametrosF.Add(new SqlParameter("nro_afiliado", nro));
            parametrosF.Add(new SqlParameter("nro_tipo_afiliado", nroTipo));
            parametrosF.Add(new SqlParameter("cant", cantBonosConsulta));
            repo.callProcedure("NN_NN.SP_BUY_CANT_BONO_FARMACIA", parametrosF);
        }

    }
      
}
