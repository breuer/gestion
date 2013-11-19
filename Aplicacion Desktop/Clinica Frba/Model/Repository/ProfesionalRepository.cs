using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.Model.Repository
{
    public class ProfesionalRepository : Repository
    {
        
        private String queryExisteMatricula = "SELECT matricula FROM [NN_NN].[PROFESIONAL] WHERE matricula = ";
        private String queryExisteProfesional = "SELECT dni FROM [NN_NN].[PROFESIONAL] WHERE dni = ";
        // TODO mas tarde ver!!!
        public DataTable existeMatricula(String matricula)
        {
            return listar(queryExisteMatricula + matricula); ;
        }

        // TODO mas tarde ver!!!
        public DataTable existeProfesional(String docuemento, String tipo)
        {
            return listar(queryExisteProfesional + docuemento + " AND codigo_documento = " + tipo);
        }

        
        public int addProfesional(List<SqlParameter> parametros)
        {
            base.callProcedure("NN_NN.SP_ADD_PROFESIONAL", parametros);

            return 1;
        }

   
    }
}
