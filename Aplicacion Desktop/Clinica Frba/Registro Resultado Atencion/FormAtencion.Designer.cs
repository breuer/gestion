namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class FormAtencion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSintomas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiagnostico = new System.Windows.Forms.TextBox();
            this.btGenerarReceta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNroConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNroAfiliado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Síntomas";
            // 
            // tbSintomas
            // 
            this.tbSintomas.Location = new System.Drawing.Point(161, 155);
            this.tbSintomas.Multiline = true;
            this.tbSintomas.Name = "tbSintomas";
            this.tbSintomas.Size = new System.Drawing.Size(533, 69);
            this.tbSintomas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnóstico";
            // 
            // tbDiagnostico
            // 
            this.tbDiagnostico.Location = new System.Drawing.Point(161, 255);
            this.tbDiagnostico.Multiline = true;
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Size = new System.Drawing.Size(533, 83);
            this.tbDiagnostico.TabIndex = 3;
            // 
            // btGenerarReceta
            // 
            this.btGenerarReceta.Location = new System.Drawing.Point(488, 35);
            this.btGenerarReceta.Name = "btGenerarReceta";
            this.btGenerarReceta.Size = new System.Drawing.Size(127, 23);
            this.btGenerarReceta.TabIndex = 4;
            this.btGenerarReceta.Text = "Agregar receta médica";
            this.btGenerarReceta.UseVisualStyleBackColor = true;
            this.btGenerarReceta.Click += new System.EventHandler(this.btGenerarReceta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consulta nro:";
            // 
            // tbNroConsulta
            // 
            this.tbNroConsulta.Location = new System.Drawing.Point(111, 19);
            this.tbNroConsulta.Name = "tbNroConsulta";
            this.tbNroConsulta.Size = new System.Drawing.Size(100, 20);
            this.tbNroConsulta.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNroAfiliado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaConsulta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNroConsulta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbNroAfiliado
            // 
            this.tbNroAfiliado.Location = new System.Drawing.Point(422, 19);
            this.tbNroAfiliado.Name = "tbNroAfiliado";
            this.tbNroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.tbNroAfiliado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nro afiliado:";
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(111, 52);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(162, 20);
            this.dtpFechaConsulta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha consulta:";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(619, 536);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(55, 536);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Receta médica:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btGenerarReceta);
            this.groupBox2.Location = new System.Drawing.Point(55, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FormAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDiagnostico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSintomas);
            this.Controls.Add(this.label1);
            this.Name = "FormAtencion";
            this.Text = "FormAtencion";
            this.Load += new System.EventHandler(this.FormAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSintomas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiagnostico;
        private System.Windows.Forms.Button btGenerarReceta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNroConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNroAfiliado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}