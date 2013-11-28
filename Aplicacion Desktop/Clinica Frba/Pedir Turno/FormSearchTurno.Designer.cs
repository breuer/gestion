namespace Clinica_Frba.Pedir_Turno
{
    partial class FormSearchTurno
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAfiliado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSeleccionarAfiliado = new System.Windows.Forms.Button();
            this.btSeleccionarProfesional = new System.Windows.Forms.Button();
            this.tbProfesional = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.cbTipoCancelacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.tbHiddenRol = new System.Windows.Forms.TextBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.gbBaja.SuspendLayout();
            this.gbTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.gbTurno);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.cbTipoCancelacion);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.dtpFecha);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbFiltro.Controls.SetChildIndex(this.dtpFecha, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbTipoCancelacion, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbTurno, 0);
            this.gbFiltro.Controls.SetChildIndex(this.gbBaja, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(85, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha:";
            // 
            // tbAfiliado
            // 
            this.tbAfiliado.Location = new System.Drawing.Point(69, 13);
            this.tbAfiliado.Name = "tbAfiliado";
            this.tbAfiliado.Size = new System.Drawing.Size(200, 20);
            this.tbAfiliado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Afiliado:";
            // 
            // btSeleccionarAfiliado
            // 
            this.btSeleccionarAfiliado.Location = new System.Drawing.Point(281, 11);
            this.btSeleccionarAfiliado.Name = "btSeleccionarAfiliado";
            this.btSeleccionarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionarAfiliado.TabIndex = 10;
            this.btSeleccionarAfiliado.Text = "Seleccionar";
            this.btSeleccionarAfiliado.UseVisualStyleBackColor = true;
            // 
            // btSeleccionarProfesional
            // 
            this.btSeleccionarProfesional.Location = new System.Drawing.Point(281, 36);
            this.btSeleccionarProfesional.Name = "btSeleccionarProfesional";
            this.btSeleccionarProfesional.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionarProfesional.TabIndex = 11;
            this.btSeleccionarProfesional.Text = "Seleccionar";
            this.btSeleccionarProfesional.UseVisualStyleBackColor = true;
            // 
            // tbProfesional
            // 
            this.tbProfesional.Location = new System.Drawing.Point(69, 38);
            this.tbProfesional.Name = "tbProfesional";
            this.tbProfesional.Size = new System.Drawing.Size(200, 20);
            this.tbProfesional.TabIndex = 12;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(6, 45);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(62, 13);
            this.l.TabIndex = 13;
            this.l.Text = "Profesional:";
            // 
            // cbTipoCancelacion
            // 
            this.cbTipoCancelacion.FormattingEnabled = true;
            this.cbTipoCancelacion.Location = new System.Drawing.Point(488, 20);
            this.cbTipoCancelacion.Name = "cbTipoCancelacion";
            this.cbTipoCancelacion.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCancelacion.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado:";
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.tbHiddenRol);
            this.gbTurno.Controls.Add(this.label3);
            this.gbTurno.Controls.Add(this.l);
            this.gbTurno.Controls.Add(this.tbAfiliado);
            this.gbTurno.Controls.Add(this.tbProfesional);
            this.gbTurno.Controls.Add(this.btSeleccionarProfesional);
            this.gbTurno.Controls.Add(this.btSeleccionarAfiliado);
            this.gbTurno.Location = new System.Drawing.Point(24, 15);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(384, 67);
            this.gbTurno.TabIndex = 17;
            this.gbTurno.TabStop = false;
            // 
            // tbHiddenRol
            // 
            this.tbHiddenRol.Location = new System.Drawing.Point(363, 36);
            this.tbHiddenRol.Name = "tbHiddenRol";
            this.tbHiddenRol.Size = new System.Drawing.Size(15, 20);
            this.tbHiddenRol.TabIndex = 14;
            this.tbHiddenRol.Visible = false;
            // 
            // FormSearchTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 515);
            this.Name = "FormSearchTurno";
            this.Text = "FormSearchTurno";
            this.Load += new System.EventHandler(this.FormSearchTurno_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbBaja.ResumeLayout(false);
            this.gbBaja.PerformLayout();
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSeleccionarAfiliado;
        private System.Windows.Forms.Button btSeleccionarProfesional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAfiliado;
        private System.Windows.Forms.TextBox tbProfesional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCancelacion;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.TextBox tbHiddenRol;
    }
}