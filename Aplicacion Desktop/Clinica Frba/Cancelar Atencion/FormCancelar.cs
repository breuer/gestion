using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class FormCancelar : FormBase
    {
        public Boolean isRango = false;

        public FormCancelar()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            if (tbMotivo.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro de cancelar la operacion?",
                    "Cancelar la operacion",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (tbMotivo.Text.Length < 0)
            {
                MessageBox.Show(
                    "Debe ingresar un comentario cuando realiza una cancelacion.",
                    "Aviso"
                );
            }
            else
            {
                if (this.AfiliadoCurrent != null)
                {


                }
                else
                {

                }
            }

        }

        private void FormCancelar_Load(object sender, EventArgs e)
        {
            base.FormBase_Load(sender, e);

            if (this.ProfesionalCurrent != null)
            {
                dpF0.Visible = true;
                dpF1.Visible = true;
            }
            else
            {
                dpF0.Visible = false;
                dpF1.Visible = false;
            }
        }
    }
}
