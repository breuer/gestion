using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Model.Repository
{
    public class ProfesionalRepository : Repository
    {
        
        private String queryExisteMatricula = "SELECT matricula FROM [NN_NN].[PROFESIONAL] WHERE matricula = ";

        // TODO mas tarde ver!!!
        public DataTable existeMatricula(String matricula)
        {
            return listar(queryExisteMatricula + matricula); ;
        }

        // TODO mas tarde ver!!!
        public DataTable existeProfesional(String matricula)
        {
            return listar(queryExisteMatricula + matricula); ;
        }
    }
}
