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
        private Decimal nroAfiliado;
        private Decimal nroDiscriminador;
        private String apellido;
        private String nombre;
        private Decimal dni;
        private Decimal tipoDocuemento;
        private String direccion;
        private Decimal codigoEstadoCivil;
        private DateTime fechaNac;
        private Decimal telefono;
        private String mail;
        private Decimal cantidadHijos;
        private DateTime fechaBaja;
        private Decimal codigoPlan;
        private Boolean habilitado;
        private String sexo;

        private static AfiliadoRepository repository = new AfiliadoRepository();

        public Afiliado()
        {
        }

        public Afiliado(DataTable data)
        {
            this.nombre = data.Rows[0]["nombre"].ToString();
            this.Apellido = data.Rows[0]["apellido"].ToString();
            this.codigoEstadoCivil = (Decimal)data.Rows[0]["cod_estado_Civil"];
            this.codigoPlan = (Decimal)data.Rows[0]["cod_plan"];
            this.tipoDocuemento = (Decimal)data.Rows[0]["codigo_documento"];
            this.dni = (Decimal)data.Rows[0]["documento"];
            this.telefono = (Decimal)data.Rows[0]["telefono"];
            this.Direccion = data.Rows[0]["direccion"].ToString();
            this.fechaNac = (DateTime)data.Rows[0]["fecha_nac"];
            this.Sexo = data.Rows[0]["sexo"].ToString();
            this.NroAfiliado = (Decimal)data.Rows[0]["numero"];
            this.nroDiscriminador = (Decimal)data.Rows[0]["numero_tipo_afiliado"];


        }

        public Afiliado(List<SqlParameter> parametros, Decimal numero, Decimal discriminador)
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


        public Decimal NroAfiliado { set { nroAfiliado = value; } get { return nroAfiliado; } }
        public Decimal NroDiscriminador { set { nroDiscriminador = value; } get { return nroDiscriminador; } }
        public String Apellido{ set { apellido = value;} get { return apellido;}}
        public String Nombre{ set { nombre = value;} get { return nombre;}}
        public Decimal Dni { set { dni = value; } get { return dni; } }
        public String Direccion{ set { direccion = value;} get { return direccion;}}
        public Decimal CodigoEstadoCivil { set { codigoEstadoCivil = value; } get { return codigoEstadoCivil; } }
        public DateTime FechaNac{ set { fechaNac = value;} get { return fechaNac;}}
        public Decimal Telefono { set { telefono = value; } get { return telefono; } }
        public String Mail{ set { mail = value;} get { return mail;}}
        public Decimal CantidadHijos { set { cantidadHijos = value; } get { return cantidadHijos; } }
        public DateTime FechaBaja{ set { fechaBaja = value;} get { return fechaBaja;}}
        public Decimal CodigoPlan { set { codigoPlan = value; } get { return codigoPlan; } }
        public Boolean Habilitado { set { habilitado = value; } get { return habilitado; } }
        public Decimal TipoDocumento { set { tipoDocuemento = value; } get { return tipoDocuemento; } }
        public String Sexo { set { sexo = value; } get { return sexo; } }
        public String ApellidoNombre
        {
            get {return Apellido + ", " + Nombre;}
        }

        public override string ToString()
        {
            Decimal id = this.NroAfiliado * 100;
            id += id + this.NroDiscriminador;
            return ApellidoNombre + " => " + id.ToString();
        }
        
        public static AfiliadoRepository getRepository
        {
            get { return repository; }
        }

    }
}
