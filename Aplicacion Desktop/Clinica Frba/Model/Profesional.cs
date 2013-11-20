using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class Profesional
    {
        private int numero;
        private String apellido;
        private String nombre;
        private int dni;
        private String direccion;
        private int telefono;
        private DateTime fechaNacimiento;
        private String mail;
        private int? matricula;
        private Boolean enable;

        private static ProfesionalRepository repository = new ProfesionalRepository();

        public Profesional() { }

        public Profesional(int numero, String apellido, String nombre, String email, int ?matricula)
        {
            this.numero = numero;
            this.apellido = apellido;
            this.nombre = nombre;
            this.matricula = matricula;
            this.mail = email;
        }

        public int Numero 
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
        public int Dni 
        {
            set { dni = value; }
            get { return dni; }
        }
        public String Direccion 
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public int? Matricula
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

    }
}
