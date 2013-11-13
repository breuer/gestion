using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class EspecialidaMedica
    {
        private int codigo;
        private String descripcion;
        private TipoEspecialidadMedica tipo;
        private Boolean enable;

        private static EspecialidadMedicaRepository repository = new EspecialidadMedicaRepository();

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public String Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public TipoEspecialidadMedica Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public Boolean Enable
        {
            set { enable = value; }
            get { return enable; }
        }
        public static EspecialidadMedicaRepository getRepository
        {
            get { return repository; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            EspecialidaMedica ep = obj as EspecialidaMedica;
            if ((System.Object)ep == null)
            {
                return false;
            }

            return codigo == ep.codigo;
        }

        public bool Equals(EspecialidaMedica ep)
        {
            if (ep == null)
            {
                return false;
            }
            return codigo == ep.codigo;
        }
        public override int GetHashCode()
        {
            return codigo;
        }
    }
}
