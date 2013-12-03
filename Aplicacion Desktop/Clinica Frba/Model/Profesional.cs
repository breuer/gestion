using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;
using System.Data;

namespace Clinica_Frba.Model
{
    public class Profesional
    {
        private Decimal numero;
        private String apellido;
        private String nombre;
        private Decimal dni;
        private String direccion;
        private Decimal telefono;
        private DateTime fechaNacimiento;
        private String mail;
        private Decimal? matricula;
        private Boolean enable;
        private String sexo;
        private String habilitado;

        private static ProfesionalRepository repository = new ProfesionalRepository();

        public Profesional() { }

        public Profesional(DataTable data) 
        {
            this.nombre = data.Rows[0]["nombre"].ToString();
            this.Apellido = data.Rows[0]["apellido"].ToString();
            this.dni = (Decimal)data.Rows[0]["dni"];
            this.telefono = (Decimal)data.Rows[0]["telefono"];
            this.Direccion = data.Rows[0]["direccion"].ToString();
            this.Sexo = data.Rows[0]["sexo"].ToString();
            this.numero = (Decimal)data.Rows[0]["numero"];
        }

        public Profesional(Decimal numero, String apellido, String nombre, String email, Decimal? matricula)
        {
            this.numero = numero;
            this.apellido = apellido;
            this.nombre = nombre;
            this.matricula = matricula;
            this.mail = email;
        }

        public Decimal Numero 
        {
            set { numero = value; }
            get { return numero; }
        }
        public String Apellido 
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public String Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public Decimal Dni 
        {
            set { dni = value; }
            get { return dni; }
        }
        public String Direccion 
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public Decimal Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public Decimal? Matricula
        {
            set { matricula = value; }
            get { return matricula; }
        }

        public DateTime FechaNacimiento 
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public String Mail
        {
            set { mail = value; }
            get { return mail; }
        }

        public Boolean Enable
        {
            set { enable = value; }
            get { return enable; }
        }

        public static ProfesionalRepository getRepository
        {
            get { return repository; }
        }

        public String ApellidoNombre
        {
            get { return Apellido + ", " + Nombre; }
        }

        public String Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public String Habilitado
        {
            set { habilitado = value; }
            get { return habilitado; }
        }
    }
}
