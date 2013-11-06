namespace Clinica_Frba.Abm_de_Planes
{
    partial class FormSearchPlanes
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
            this.lName = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // btLimpiar
            // 
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.tbDescripcion);
            this.gbFiltro.Controls.Add(this.lName);
            this.gbFiltro.Controls.SetChildIndex(this.lName, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbDescripcion, 0);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(10, 27);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(47, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Nombre:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(63, 24);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(133, 20);
            this.tbDescripcion.TabIndex = 1;
            // 
            // FormSearchPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Name = "FormSearchPlanes";
            this.Text = "FormSearchPlanes";
            this.Load += new System.EventHandler(this.FormSearchPlanes_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}