using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.Model.Repository
{
    public class AfiliadoRepository : Repository
    {
        private String queryComboEstadoCivil = "SELECT [codigo], [descripcion] As estadoCivil FROM [GD2C2013].[NN_NN].[ESTADO_CIVIL]";
        private String queryComboTipoDocumento = "SELECT [codigo], [descripcion] As tipo FROM [GD2C2013].[NN_NN].[TIPO_DOCUMENTO]";
        
        private String queryExisteAfiliado = "SELECT dni FROM [NN_NN].[AFILIADO] WHERE dni = ";
        
        public DataTable getEstadoCivil()
        {
            return listar(queryComboEstadoCivil);
        }

        public DataTable getTipoDocumento()
        {
            return listar(queryComboTipoDocumento);
        }

        // TODO mas tarde ver!!!
        public DataTable existeAfiliado(String dni)
        {
            return listar(queryExisteAfiliado + dni); ;
        }
    }
}
