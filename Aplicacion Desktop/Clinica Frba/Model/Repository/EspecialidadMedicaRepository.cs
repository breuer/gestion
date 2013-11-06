using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_Frba.Model.Repository
{
    public class EspecialidadMedicaRepository : Repository
    {
        public const String queryComboPlanes = "SELECT codigo, descripcion FROM [NN_NN].[TIPO_ESPECIALIDAD_MEDICA]";
        public const String stListar = "[NN_NN].[sp_listar_especialidad]";

        public DataTable getTipo()
        {
            return listar(queryComboPlanes);
        }
        
    }
}
