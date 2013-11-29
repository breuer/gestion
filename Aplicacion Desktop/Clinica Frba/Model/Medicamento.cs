using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Model
{
    class Medicamento
    {
        private string descripcíon;
        private int nroBono;
        private int cantidad;
        public string Descripcion { set { descripcíon = value; } get { return descripcíon; } }
        public int NroBono { set { nroBono = value; } get { return nroBono; } }
        public int Cantidad { set { cantidad = value; } get { return cantidad; } }
    }
}
