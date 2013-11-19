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
        public const String queryComboTipo = "SELECT codigo, descripcion FROM [NN_NN].[TIPO_ESPECIALIDAD]";
        public const String stListar = "[NN_NN].[sp_listar_especialidad]";

        public DataTable getTipo()
        {
            return listar(queryComboTipo);
        }
        public DataTable getEspecialidades()
        {
            return null;
        }
        public List<TipoEspecialidadMedica> getTipoList()
        {
            DataTable dt = listar(queryComboTipo);
            List<TipoEspecialidadMedica> lst = new List<TipoEspecialidadMedica>();
            foreach (DataRow row in dt.Rows)
            {
                TipoEspecialidadMedica tipo = new TipoEspecialidadMedica();
                tipo.Codigo = Int32.Parse(row["codigo"].ToString());
                tipo.Descripcion = row["descripcion"].ToString();
                lst.Add(tipo);
            }
            return lst;
        }
        public List<EspecialidaMedica> getEspecialidadList()
        {
            DataTable dt = listar("[NN_NN].[sp_listar_especialidad]", new List<SqlParameter>());
            List<EspecialidaMedica> lst = new List<EspecialidaMedica>();
            foreach (DataRow row in dt.Rows)
            {
                EspecialidaMedica especialidad = new EspecialidaMedica();
                especialidad.Codigo = Int32.Parse(row["codigo"].ToString());
                especialidad.Descripcion = row["descripcion"].ToString();
                especialidad.Tipo.Codigo = Int32.Parse(row["codigo_tipo"].ToString());
                especialidad.Tipo.Descripcion = row["descripcion_tipo"].ToString(); ;
                lst.Add(especialidad);
            }
            return lst;
        }
    }
}
