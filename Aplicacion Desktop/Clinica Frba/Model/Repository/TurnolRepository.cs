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
            return listar(queryTipoCancelacion + docuemento + " AND codigo_documento = " + tipo);
        }

        
        public int addProfesional(List<SqlParameter> parametros)
        {
            base.callProcedure("NN_NN.SP_ADD_PROFESIONAL", parametros);

            return 1;
        }

   
    }
}
