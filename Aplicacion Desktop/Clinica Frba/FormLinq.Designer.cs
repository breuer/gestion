﻿namespace Clinica_Frba
{
    partial class FormLinq
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbPrueba = new System.Windows.Forms.TextBox();
            this.tbSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPrueba
            // 
            this.tbPrueba.Location = new System.Drawing.Point(12, 12);
            this.tbPrueba.Multiline = true;
            this.tbPrueba.Name = "tbPrueba";
            this.tbPrueba.Size = new System.Drawing.Size(365, 295);
            this.tbPrueba.TabIndex = 1;
            // 
            // tbSalida
            // 
            this.tbSalida.Location = new System.Drawing.Point(431, 12);
            this.tbSalida.Multiline = true;
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.Size = new System.Drawing.Size(369, 295);
            this.tbSalida.TabIndex = 2;
            // 
            // FormLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 408);
            this.Controls.Add(this.tbSalida);
            this.Controls.Add(this.tbPrueba);
            this.Controls.Add(this.button1);
            this.Name = "FormLinq";
            this.Text = "FormLinq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPrueba;
        private System.Windows.Forms.TextBox tbSalida;
    }
}