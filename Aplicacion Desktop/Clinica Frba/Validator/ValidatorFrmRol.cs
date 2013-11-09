using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Validator
{
    public class ValidatorFrmRol : Validator
    {
        public static String Validador(GroupBox groupBox)
        {
            StringBuilder msg = new StringBuilder();

            if (!TextBoxValidated(groupBox, "tbNombre", 255))
            {
                msg.Append("Nombre: Debe estar presente y no debe superar los 255 caracteres\n");
            }
            if (!CheckedValidated(groupBox, "ckListFuncionalidad"))
            {
                msg.Append("Funcionalidades: Debe agregar al menos una\n");
            }
            return msg.ToString(); ;
        }
    }
}
