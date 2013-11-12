using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class Afiliado
    {
        private int nroAfiliado;
        private int nroDiscriminador;
        private String apellido;
        private String nombre;
        private int dni;
        private String direccion;
        private int codigoEstadoCivil;
        private DateTime fechaNac;
        private int telefono;
        private String mail;
        private int cantidadHijos;
        private DateTime fechaBaja;
        private int codigoPlan;
        private Boolean habilitado;
        private static AfiliadoRepository repository = new AfiliadoRepository();
       
        public int NroAfiliado{ set { nroAfiliado = value;} get { return nroAfiliado;}}
        public int NroDiscriminador{ set { nroDiscriminador = value;} get { return nroDiscriminador;}}
        public String Apellido{ set { apellido = value;} get { return apellido;}}
        public String Nombre{ set { nombre = value;} get { return nombre;}}
        public int Dni{ set { dni = value;} get { return dni;}}
        public String Direccion{ set { direccion = value;} get { return direccion;}}
        public int CodigoEstadoCivil{ set { codigoEstadoCivil = value;} get { return codigoEstadoCivil;}}
        public DateTime FechaNac{ set { fechaNac = value;} get { return fechaNac;}}
        public int Telefono{ set { telefono = value;} get { return telefono;}}
        public String Mail{ set { mail = value;} get { return mail;}}
        public int CantidadHijos { set { cantidadHijos = value; } get { return cantidadHijos; } }
        public DateTime FechaBaja{ set { fechaBaja = value;} get { return fechaBaja;}}
        public int CodigoPlan{ set { codigoPlan = value;} get { return codigoPlan;}}
        public Boolean Habilitado { set { habilitado = value; } get { return habilitado; } }

        public static AfiliadoRepository getRepository
        {
            get { return repository; }
        }

    }
}
