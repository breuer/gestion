using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Model.Repository
{

    public class PlanMedicoRepository : Repository
    {
       

        private String queryComboPlanes = "SELECT [codigo],[descripcion],[precio_bono_consulta],[precio_bono_farmacia] FROM [GD2C2013].[NN_NN].[PLAN_MEDICO]";
        public DataTable getPlanes()
        {
            return listar(queryComboPlanes);
        }         
    }

   
}
