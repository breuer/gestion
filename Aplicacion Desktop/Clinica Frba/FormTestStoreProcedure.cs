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

namespace Clinica_Frba
{
    public partial class FormTestStoreProcedure : Form
    {
        public FormTestStoreProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder st = new StringBuilder();
            st.Append("Prueba store procedure con valor de retorno:[");


            Repository repo = new Repository();

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("param1", "Esto es una prueba"));
            SqlParameter salid = new SqlParameter("return", SqlDbType.Text);
            salid.Direction = ParameterDirection.ReturnValue;
            parametros.Add(salid);
            
            List<SqlParameter> rta = repo.callProcedure("NN_NN.SP_TEST_RETURN", parametros);

            foreach(SqlParameter s in rta){
                st.Append(s.Value + "]");
            }
        }
    }
}
