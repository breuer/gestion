namespace Clinica_Frba.Abm_de_Rol
{
    partial class FormAltaRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.ckListFuncionalidad = new System.Windows.Forms.CheckedListBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.ckListFuncionalidad);
            this.gbControl.Controls.Add(this.tbNombre);
            this.gbControl.Controls.Add(this.label1);
            // 
            // btLimpiar
            // 
           // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Funcionalidades:";
            // 
            // ckListFuncionalidad
            // 
            this.ckListFuncionalidad.CheckOnClick = true;
            this.ckListFuncionalidad.FormattingEnabled = true;
            this.ckListFuncionalidad.Location = new System.Drawing.Point(134, 46);
            this.ckListFuncionalidad.Name = "ckListFuncionalidad";
            this.ckListFuncionalidad.Size = new System.Drawing.Size(260, 199);
            this.ckListFuncionalidad.TabIndex = 23;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 284);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(260, 20);
            this.tbNombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre: ";
            // 
            // FormAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 469);
            this.Name = "FormAltaRol";
            this.Text = "FormAltaRol";
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckListFuncionalidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
    }
}