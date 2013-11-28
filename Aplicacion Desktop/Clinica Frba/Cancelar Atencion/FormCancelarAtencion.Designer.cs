namespace Clinica_Frba.Cancelar_Atencion
{
    partial class FormCancelarAtencion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.paAfiliado = new System.Windows.Forms.Panel();
            this.gbAfiliado = new System.Windows.Forms.GroupBox();
            this.paAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // paAfiliado
            // 
            this.paAfiliado.Controls.Add(this.gbAfiliado);
            this.paAfiliado.Location = new System.Drawing.Point(12, 12);
            this.paAfiliado.Name = "paAfiliado";
            this.paAfiliado.Size = new System.Drawing.Size(742, 370);
            this.paAfiliado.TabIndex = 0;
            // 
            // gbAfiliado
            // 
            this.gbAfiliado.Location = new System.Drawing.Point(3, 3);
            this.gbAfiliado.Name = "gbAfiliado";
            this.gbAfiliado.Size = new System.Drawing.Size(736, 364);
            this.gbAfiliado.TabIndex = 0;
            this.gbAfiliado.TabStop = false;
            this.gbAfiliado.Text = "groupBox1";
            this.gbAfiliado.Enter += new System.EventHandler(this.gbAfiliado_Enter);
            // 
            // FormCancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 394);
            this.Controls.Add(this.paAfiliado);
            this.Name = "FormCancelarAtencion";
            this.Text = "FormCancelarAtencion";
            this.paAfiliado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paAfiliado;
        private System.Windows.Forms.GroupBox gbAfiliado;
    }
}