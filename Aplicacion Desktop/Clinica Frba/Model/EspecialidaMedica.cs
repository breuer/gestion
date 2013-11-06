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

    }
}
