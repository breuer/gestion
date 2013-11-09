using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Clinica_Frba.Model.Repository
{
    public class RolRepository : Repository
    {
        public const String queryFuncionalidades = "SELECT id, nombre AS funcionalidad FROM [NN_NN].[FUNCIONALIDAD]";
        
        public DataTable getFuncionalidades()
        {
            return listar(queryFuncionalidades);
        }
    }
}
