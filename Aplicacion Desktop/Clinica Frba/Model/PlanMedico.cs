using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class PlanMedico
    {
        private String codigo;
        private String descripcion;
        private float precioBonoFarmacia;
        private float precioBonoConsulta;
        private Boolean enable;
        private Boolean isHistorico;
        private static PlanMedicoRepository repository = new PlanMedicoRepository();

        public String Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public String Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public float PrecioBonoFarmacia
        {
            set { precioBonoFarmacia = value; }
            get { return precioBonoFarmacia; }
        }
        public float PrecioBonoConsulta
        {
            set { precioBonoConsulta = value; }
            get { return precioBonoConsulta;}
        }
        public Boolean Enable
        {
            set { enable = value; }
            get { return enable; }
        }
        public Boolean IsHistorico
        {
            set { isHistorico = value; }
            get { return isHistorico; }
        }
        public static PlanMedicoRepository getRepository
        {
            get { return repository; }
        }

    }
}
