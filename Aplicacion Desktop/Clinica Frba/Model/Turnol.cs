using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class Turno
    {
        private int numero;
        private DateTime fecha;
        private DateTime? fechaLlegada;
        private int? nroAfiliado;
        private int? nroTipoAfiliado;
        private int nroProfesional;
        private int nroDay;

        private static TurnoRepository repository = new TurnoRepository();

        public Turno() { }

        public int Numero 
        {
            set { numero = value; }
            get { return numero; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public DateTime? FechaLlegada
        {
            set { fechaLlegada = value; }
            get { return fechaLlegada; }
        }

        public int? NroAfiliado 
        {
            set { nroAfiliado = value; }
            get { return nroAfiliado; }
        }
        public int? NroTipoAfiliado 
        {
            set { nroTipoAfiliado = value; }
            get { return nroTipoAfiliado; }
        }

        public int NroProfesional 
        {
            set { nroProfesional = value; }
            get { return nroProfesional; }
        }

        public int NroDay 
        {
            set { nroDay = value; }
            get { return nroDay; }
        }

        
        public static TurnoRepository getRepository
        {
            get { return repository; }
        }

    }
}
