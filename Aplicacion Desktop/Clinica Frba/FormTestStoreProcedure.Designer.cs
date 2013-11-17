namespace Clinica_Frba
{
    partial class FormTestStoreProcedure
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(26, 23);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(760, 310);
            this.tbOutput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SP return value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTestStoreProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbOutput);
            this.Name = "FormTestStoreProcedure";
            this.Text = "FormTestStoreProcedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button button1;
    }
}