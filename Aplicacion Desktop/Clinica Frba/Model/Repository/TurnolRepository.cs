using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.Model.Repository
{
    public class TurnoRepository : Repository
    {
        
        private String queryTipoCancelacion = "SELECT codigo AS tipoCancelacion, descripcion FROM [NN_NN].[TIPO_CANCELACION]";
        // TODO mas tarde ver!!!
        public DataTable fillCombo()
        {
            return listar(queryTipoCancelacion); ;
        }

        // TODO mas tarde ver!!!
        public DataTable existeProfesional(String docuemento, String tipo)
        {
            DataTable dt = listar(queryTipoCancelacion + docuemento + " AND codigo_documento = " + tipo);
            DataRow row = dt.NewRow();
            row["tipoCancelacion"] = 0;
            row["descripcion"] = "libre";
            dt.Rows.Add(row);
            return dt;
        }

        
        public int addProfesional(List<SqlParameter> parametros)
        {
            base.callProcedure("NN_NN.SP_ADD_PROFESIONAL", parametros);

            return 1;
        }

   
    }
}
