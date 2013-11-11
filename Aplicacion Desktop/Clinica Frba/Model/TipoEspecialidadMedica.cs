using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Model
{
    public class TipoEspecialidadMedica
    {
        private int codigo;
        private String descripcion;

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

    }
}
