namespace Clinica_Frba.Cancelar_Atencion
{
    partial class FormCancelar
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
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.dpF0 = new System.Windows.Forms.DateTimePicker();
            this.dpF1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(9, 33);
            this.tbMotivo.MaxLength = 127;
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(910, 100);
            this.tbMotivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esplique el motivo de la cancelacion en no mas de 127 caracteres";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(847, 190);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(766, 190);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 3;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // dpF0
            // 
            this.dpF0.CustomFormat = "MM/dd/yyyy";
            this.dpF0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpF0.Location = new System.Drawing.Point(9, 139);
            this.dpF0.Name = "dpF0";
            this.dpF0.Size = new System.Drawing.Size(200, 20);
            this.dpF0.TabIndex = 4;
            // 
            // dpF1
            // 
            this.dpF1.CustomFormat = "MM/dd/yyyy";
            this.dpF1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpF1.Location = new System.Drawing.Point(265, 139);
            this.dpF1.Name = "dpF1";
            this.dpF1.Size = new System.Drawing.Size(200, 20);
            this.dpF1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // FormCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 225);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dpF1);
            this.Controls.Add(this.dpF0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Name = "FormCancelar";
            this.Text = "FormCancelar";
            this.Load += new System.EventHandler(this.FormCancelar_Load);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dpF0, 0);
            this.Controls.SetChildIndex(this.dpF1, 0);
            this.Controls.SetChildIndex(this.btVolver, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbMotivo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.DateTimePicker dpF0;
        private System.Windows.Forms.DateTimePicker dpF1;
        private System.Windows.Forms.Label label2;
    }
}