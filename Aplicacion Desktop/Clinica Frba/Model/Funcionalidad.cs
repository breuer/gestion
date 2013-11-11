using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Model
{
    public class Funcionalidad
    {
        private int id;
        private String nombre;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public String Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }
    }
}
