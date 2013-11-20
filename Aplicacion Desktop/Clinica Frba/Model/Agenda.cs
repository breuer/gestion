using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class Agenda
    {
        private int numero;
        private int nroProfesional;
        private DateTime fechaFin;
        private DateTime fechaInicio;

        private Boolean habilitado;
        private static AgendaRepository repository = new AgendaRepository();

        public int Numero { set { numero = value; } get { return numero; } }
        public int NroProfesional { set { nroProfesional = value; } get { return nroProfesional; } }
        public DateTime FechaFin { set { fechaFin = value; } get { return fechaFin; } }
        public DateTime FechaInicio { set { fechaInicio = value; } get { return fechaInicio; } }
        
        public Boolean Habilitado { set { habilitado = value; } get { return habilitado; } }

        public static AgendaRepository getRepository
        {
            get { return repository; }
        }
    }
}
