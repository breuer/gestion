namespace Clinica_Frba.Abm_de_Especialidades_Medicas
{
    partial class FormSearchEspecialidad
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
            this.cbTipoEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.tbCodigo);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.tbDescripcion);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.cbTipoEspecialidad);
            this.gbFiltro.Controls.SetChildIndex(this.cbTipoEspecialidad, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbDescripcion, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbCodigo, 0);
            // 
            // cbTipoEspecialidad
            // 
            this.cbTipoEspecialidad.FormattingEnabled = true;
            this.cbTipoEspecialidad.Location = new System.Drawing.Point(144, 16);
            this.cbTipoEspecialidad.Name = "cbTipoEspecialidad";
            this.cbTipoEspecialidad.Size = new System.Drawing.Size(248, 21);
            this.cbTipoEspecialidad.TabIndex = 5;
            this.cbTipoEspecialidad.Tag = "codigoTipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo especialidad Medica: ";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(144, 49);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(248, 20);
            this.tbDescripcion.TabIndex = 9;
            this.tbDescripcion.Tag = "descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(480, 49);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(155, 20);
            this.tbCodigo.TabIndex = 12;
            this.tbCodigo.Tag = "codigo";
            // 
            // FormSearchEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 509);
            this.Name = "FormSearchEspecialidad";
            this.Text = "FormSearchEspecialidad";
            this.Load += new System.EventHandler(this.FormSearchEspecialidad_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoEspecialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}