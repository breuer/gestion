namespace Clinica_Frba.Abm_de_Rol
{
    partial class FormSearchRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFuncionalidad = new System.Windows.Forms.ComboBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.tbNombre);
            this.gbFiltro.Controls.Add(this.cbFuncionalidad);
            this.gbFiltro.Controls.SetChildIndex(this.cbFuncionalidad, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbNombre, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label1, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(82, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(147, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcionalidad:";
            // 
            // cbFuncionalidad
            // 
            this.cbFuncionalidad.FormattingEnabled = true;
            this.cbFuncionalidad.Location = new System.Drawing.Point(108, 62);
            this.cbFuncionalidad.Name = "cbFuncionalidad";
            this.cbFuncionalidad.Size = new System.Drawing.Size(121, 21);
            this.cbFuncionalidad.TabIndex = 7;
            // 
            // FormSearchRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Name = "FormSearchRol";
            this.Text = "FormSearchRol";
            this.Load += new System.EventHandler(this.FormSearchRol_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFuncionalidad;
    }
}