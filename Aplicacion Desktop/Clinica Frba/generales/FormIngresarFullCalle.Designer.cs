namespace Clinica_Frba.Generales
{
    partial class FormIngresarFullCalle
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
            this.gbCalle = new System.Windows.Forms.GroupBox();
            this.btaceptar = new System.Windows.Forms.Button();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalle
            // 
            this.gbCalle.Controls.Add(this.btaceptar);
            this.gbCalle.Controls.Add(this.tbCiudad);
            this.gbCalle.Controls.Add(this.label5);
            this.gbCalle.Controls.Add(this.tbDto);
            this.gbCalle.Controls.Add(this.label4);
            this.gbCalle.Controls.Add(this.tbPiso);
            this.gbCalle.Controls.Add(this.tbNumero);
            this.gbCalle.Controls.Add(this.tbCalle);
            this.gbCalle.Controls.Add(this.label3);
            this.gbCalle.Controls.Add(this.label2);
            this.gbCalle.Controls.Add(this.label1);
            this.gbCalle.Location = new System.Drawing.Point(1, 12);
            this.gbCalle.Name = "gbCalle";
            this.gbCalle.Size = new System.Drawing.Size(273, 154);
            this.gbCalle.TabIndex = 0;
            this.gbCalle.TabStop = false;
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(183, 120);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(75, 23);
            this.btaceptar.TabIndex = 10;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(70, 94);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(188, 20);
            this.tbCiudad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad:";
            // 
            // tbDto
            // 
            this.tbDto.Location = new System.Drawing.Point(186, 63);
            this.tbDto.Name = "tbDto";
            this.tbDto.Size = new System.Drawing.Size(72, 20);
            this.tbDto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dto:";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(70, 63);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(72, 20);
            this.tbPiso.TabIndex = 5;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(70, 37);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(188, 20);
            this.tbNumero.TabIndex = 4;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(70, 13);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(188, 20);
            this.tbCalle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Piso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calle:";
            // 
            // FormIngresarFullCalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 170);
            this.Controls.Add(this.gbCalle);
            this.Name = "FormIngresarFullCalle";
            this.Text = "FormIngresarFullCalle";
            this.gbCalle.ResumeLayout(false);
            this.gbCalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalle;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btaceptar;

    }
}