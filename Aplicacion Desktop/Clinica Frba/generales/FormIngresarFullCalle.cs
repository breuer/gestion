using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;
using Clinica_Frba.Validator;
using Clinica_Frba.Interface;

namespace Clinica_Frba.Generales
{
    public partial class FormIngresarFullCalle : FormBase
    {
        public FormIngresarFullCalle()
        {
            InitializeComponent();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            String msg = ValidatorFrmFullCalle.Validador(gbCalle);

            if (!msg.Equals(String.Empty))
            {
                DialogResult result = MessageBox.Show(
                    msg,
                    Application.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                IFInvocanteCalle iDestino = this.Owner as IFInvocanteCalle;
                if (iDestino != null)
                {
                    StringBuilder st = new StringBuilder();
                    st.Append(this.tbCalle.Text);
                    st.Append(" ");
                    st.Append(this.tbNumero.Text);

                    if (!this.tbPiso.Equals(String.Empty) && !this.tbDto.Equals(String.Empty))
                    {
                        st.Append(" ");
                        st.Append(this.tbPiso.Text);
                        st.Append(" ");
                        st.Append(this.tbDto.Text);
                    }
                    st.Append(" (");
                    st.Append(tbCiudad.Text + ")");
                    iDestino.seleccionar(st.ToString());
                    this.Close();
                }
            }
        }

      
    }
}
