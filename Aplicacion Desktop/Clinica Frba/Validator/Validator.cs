using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clinica_Frba.Validator
{
    public class Validator
    {
        protected static string mail = "^((?:(?:(?:[a-zA-Z0-9][\\.\\-\\+_]?)*)[a-zA-Z0-9])+)\\@((?:(?:(?:[a-zA-Z0-9][\\.\\-_]?){0,62})[a-zA-Z0-9])+)\\.([a-zA-Z0-9]{2,6})$";

        


        protected static bool TextBoxValidated(GroupBox groupBox, string name, Int32 length)
        {
            TextBox tb = (TextBox)groupBox.Controls[name];
            string msgError = "";
            if ("".Equals(tb.Text))
            {
                //this.errorProvider.SetError(tb, "Campo obligatorio");
                return false;
            }
            if (tb.Text.Length > length)
            {
                msgError = "El largo del campo no puede superar los 255 caracteres";
            }
            if (!"".Equals(msgError))
            {
                //this.errorProvider.SetError(tb, msgError);
                return false;
            }
            return true;
        }

        protected static bool CheckedValidated(GroupBox groupBox, String name)
        {
            CheckedListBox clb = (CheckedListBox)groupBox.Controls[name];

            if (clb.CheckedItems.Count == 0)
            {
                //this.errorProvider.SetError(clb, "Campo obligatorio");
                return false;
            }
            return true;
        }

        protected static bool TextBoxValidatedMail(GroupBox groupBox, string name, bool isNullAble)
        {
            TextBox tb = (TextBox)groupBox.Controls[name];
            string msgError = "";
            if ("".Equals(tb.Text) && isNullAble)
            {
                return true;
            }
            else if ("".Equals(tb.Text) && !isNullAble)
            {
                //this.errorProvider.SetError(tb, "Campo obligatorio");
                return false;
            }
            if (tb.Text.Length > 50)
            {
                msgError = "error";
            
            }

            if (!Regex.Match(tb.Text, mail).Success)
            {
                msgError = msgError + " " + "Error Mail";
            }

            if (!"".Equals(msgError))
            {
                //this.errorProvider.SetError(tb, msgError);
                return false;
            }
            return true;
        }

    }
}
