using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.Model
{
    public class Rol
    {
        private int id;
        private String nombre;
        private Boolean habilitado;
        private List<string> funcionalidades = new List<string>();
        
        private static RolRepository repository = new RolRepository();

        public String Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
       
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public Boolean Habilitado
        {
            set { habilitado = value; }
            get { return habilitado; }
        }
        public static RolRepository getRepository
        {
            get { return repository; }
        }

        public List<string> Funcionaliadades
        {
            set { funcionalidades = value; }
            get { return funcionalidades; }
        }
    }
}
