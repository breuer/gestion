using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Validator
{
    public class ValidatorFrmProfesional : Validator
    {
        public static String Validador(GroupBox groupBox)
        {
            StringBuilder msg = new StringBuilder();

            if (!TextBoxValidated(groupBox, "tbNombre", 255))
            {
                msg.Append("Nombre: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!TextBoxValidated(groupBox, "tbApellido", 255))
            {
                msg.Append("Apellido: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!TextBoxValidated(groupBox, "tbDni", 9))
            {
                msg.Append("Numero: Debe estar presente y no debe superar los 9 digitos\n");
            }
            if (!TextBoxValidated(groupBox, "tbTelefono", 9))
            {
                msg.Append("Telefono: Debe estar presente y no debe superar los 9 digitos\n");
            }
            if (!TextBoxValidated(groupBox, "tbMatricula", 9))
            {
                msg.Append("Matricula: Debe estar presente y no debe superar los 9 digitos\n");
            }
            if (!TextBoxValidated(groupBox, "tbDireccion", 255))
            {
                msg.Append("Direccion: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!TextBoxValidatedMail(groupBox, "tbMail", false))
            {
                msg.Append("Mail: Debe estar presente y debe tener la forma de uno\n");
            }
            return msg.ToString(); ;
        }
    }
}
