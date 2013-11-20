namespace Clinica_Frba.Abm_de_Profesional
{
    partial class FormSearchProfesional
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.gbTipoEspecialidad = new System.Windows.Forms.GroupBox();
            this.btLimpiarCombo = new System.Windows.Forms.Button();
            this.cbTipoEspecialidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.gbBaja.SuspendLayout();
            this.gbTipoEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBusqueda
            // 
            this.pBusqueda.Size = new System.Drawing.Size(913, 475);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(3, 447);
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(828, 447);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.gbTipoEspecialidad);
            this.gbFiltro.Controls.Add(this.tbMatricula);
            this.gbFiltro.Controls.Add(this.tbApellido);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.tbNombre);
            this.gbFiltro.Controls.SetChildIndex(this.tbNombre, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbBaja, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbApellido, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbMatricula, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbTipoEspecialidad, 0);
            // 
            // gbBaja
            // 
            this.gbBaja.Location = new System.Drawing.Point(661, 19);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(69, 16);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(151, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matricula:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(69, 42);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(151, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(69, 68);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(151, 20);
            this.tbMatricula.TabIndex = 10;
            // 
            // gbTipoEspecialidad
            // 
            this.gbTipoEspecialidad.Controls.Add(this.btLimpiarCombo);
            this.gbTipoEspecialidad.Controls.Add(this.cbTipoEspecialidad);
            this.gbTipoEspecialidad.Controls.Add(this.label5);
            this.gbTipoEspecialidad.Controls.Add(this.label4);
            this.gbTipoEspecialidad.Controls.Add(this.cbEspecialidad);
            this.gbTipoEspecialidad.Location = new System.Drawing.Point(239, 13);
            this.gbTipoEspecialidad.Name = "gbTipoEspecialidad";
            this.gbTipoEspecialidad.Size = new System.Drawing.Size(321, 100);
            this.gbTipoEspecialidad.TabIndex = 11;
            this.gbTipoEspecialidad.TabStop = false;
            // 
            // btLimpiarCombo
            // 
            this.btLimpiarCombo.Location = new System.Drawing.Point(216, 71);
            this.btLimpiarCombo.Name = "btLimpiarCombo";
            this.btLimpiarCombo.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarCombo.TabIndex = 18;
            this.btLimpiarCombo.Text = "Limpiar";
            this.btLimpiarCombo.UseVisualStyleBackColor = true;
            this.btLimpiarCombo.Click += new System.EventHandler(this.btLimpiarCombo_Click);
            // 
            // cbTipoEspecialidad
            // 
            this.cbTipoEspecialidad.FormattingEnabled = true;
            this.cbTipoEspecialidad.Location = new System.Drawing.Point(106, 19);
            this.cbTipoEspecialidad.Name = "cbTipoEspecialidad";
            this.cbTipoEspecialidad.Size = new System.Drawing.Size(184, 21);
            this.cbTipoEspecialidad.TabIndex = 17;
            this.cbTipoEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbTipoEspecialidad_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Especialidad:";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(106, 50);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(184, 21);
            this.cbEspecialidad.TabIndex = 14;
            this.cbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbEspecialidad_SelectionChangeCommitted);
            // 
            // FormSearchProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 509);
            this.Name = "FormSearchProfesional";
            this.Text = "FormSearchProfesional";
            this.Load += new System.EventHandler(this.FormSearchProfesional_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbBaja.ResumeLayout(false);
            this.gbBaja.PerformLayout();
            this.gbTipoEspecialidad.ResumeLayout(false);
            this.gbTipoEspecialidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.GroupBox gbTipoEspecialidad;
        private System.Windows.Forms.ComboBox cbTipoEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Button btLimpiarCombo;
    }
}