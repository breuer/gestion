using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Model.Repository
{
    public class AgendaRepository : Repository
    {
        private String queryDias = "SELECT [codigo], [descripcion] FROM [GD2C2013].[NN_NN].[DIA]";
        
        public DataTable getDias()
        {
            return listar(queryDias);
        }

      }
}
