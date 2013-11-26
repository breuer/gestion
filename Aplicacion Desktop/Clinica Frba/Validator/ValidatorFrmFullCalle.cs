using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Validator
{
    public class ValidatorFrmFullCalle : Validator
    {
        public static String Validador(GroupBox groupBox)
        {
            StringBuilder msg = new StringBuilder();

            if (!TextBoxValidated(groupBox, "tbCalle", 255))
            {
                msg.Append("Calle: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!TextBoxValidated(groupBox, "tbNumero", 255))
            {
                msg.Append("Numero: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!TextBoxValidated(groupBox, "tbCiudad", 255))
            {
                msg.Append("Ciudad: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            return msg.ToString(); ;
        }
    }
}
