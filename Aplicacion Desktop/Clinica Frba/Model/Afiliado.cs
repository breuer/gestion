using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_Frba.Model
{
    public class Afiliado
    {
        private int nroAfiliado;
        private int nroDiscriminador;
        private String apellido;
        private String nombre;
        private int dni;
        private int tipoDocuemento;
        private String direccion;
        private int codigoEstadoCivil;
        private DateTime fechaNac;
        private int telefono;
        private String mail;
        private int cantidadHijos;
        private DateTime fechaBaja;
        private int codigoPlan;
        private Boolean habilitado;
        private char sexo;

        private static AfiliadoRepository repository = new AfiliadoRepository();

        public Afiliado()
        {
        }

        public Afiliado(DataTable data)
        {
            this.nombre = data.Rows[0]["nombre"].ToString();
            this.Apellido = data.Rows[0]["apellido"].ToString();
            this.codigoEstadoCivil = (Int32)data.Rows[0]["cod_estado_Civil"];
            this.codigoPlan = (Int32)data.Rows[0]["cod_plan"];
            this.tipoDocuemento = (Int32)data.Rows[0]["codigo_documento"];
            this.dni = (Int32)data.Rows[0]["documento"];
            this.telefono = (Int32)data.Rows[0]["telefono"];
            this.Direccion = data.Rows[0]["direccion"].ToString();
            this.fechaNac = (DateTime)data.Rows[0]["fecha_nac"];
            this.Sexo = (char)data.Rows[0]["sexo"];
            this.NroAfiliado = (Int32)data.Rows[0]["numero"];
            this.nroDiscriminador = (Int32)data.Rows[0]["numero_tipo_afiliado"];


        }

        public Afiliado(List<SqlParameter> parametros, Int32 numero, Int32 discriminador)
        {
            this.NroAfiliado = numero;
            this.NroDiscriminador = discriminador;
            foreach (SqlParameter sql in parametros)
            {
                switch (sql.ParameterName)
                {
                    // Deberia usar refelxion pero no llego
                    case "apellido":
                        this.apellido = sql.Value.ToString();
                        break;
                    case "nombre":
                        this.nombre = sql.Value.ToString();
                        break;  
                }
            }
        }


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
        public int TipoDocumento { set { tipoDocuemento = value; } get { return tipoDocuemento; } }
        public Char Sexo { set { sexo = value; } get { return sexo; } }
        public String ApellidoNombre
        {
            get {return Apellido + ", " + Nombre;}
        }

        public override string ToString()
        {
            long id = this.NroAfiliado * 100;
            id += id + this.NroDiscriminador;
            return ApellidoNombre + " => " + id.ToString();
        }
        
        public static AfiliadoRepository getRepository
        {
            get { return repository; }
        }

    }
}
