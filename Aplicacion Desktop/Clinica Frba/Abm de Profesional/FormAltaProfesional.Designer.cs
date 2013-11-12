namespace Clinica_Frba.NewFolder13
{
    partial class FormAltaProfesional
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
            this.btSearchPlan = new System.Windows.Forms.Button();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.lPlan = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lmatricula = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.tbMatricula);
            this.gbControl.Controls.Add(this.lmatricula);
            this.gbControl.Controls.Add(this.btSearchPlan);
            this.gbControl.Controls.Add(this.cbPlan);
            this.gbControl.Controls.Add(this.lPlan);
            this.gbControl.Controls.Add(this.cbEstadoCivil);
            this.gbControl.Controls.Add(this.groupBox2);
            this.gbControl.Controls.Add(this.dtFechaNacimiento);
            this.gbControl.Controls.Add(this.tbTelefono);
            this.gbControl.Controls.Add(this.tbDni);
            this.gbControl.Controls.Add(this.cbTipo);
            this.gbControl.Controls.Add(this.tbApellido);
            this.gbControl.Controls.Add(this.tbNombre);
            this.gbControl.Controls.Add(this.label13);
            this.gbControl.Controls.Add(this.label12);
            this.gbControl.Controls.Add(this.label11);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Size = new System.Drawing.Size(482, 415);
            // 
            // btSearchPlan
            // 
            this.btSearchPlan.Location = new System.Drawing.Point(252, 261);
            this.btSearchPlan.Name = "btSearchPlan";
            this.btSearchPlan.Size = new System.Drawing.Size(75, 23);
            this.btSearchPlan.TabIndex = 62;
            this.btSearchPlan.Text = "Buscar";
            this.btSearchPlan.UseVisualStyleBackColor = true;
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(96, 261);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(150, 21);
            this.cbPlan.TabIndex = 61;
            // 
            // lPlan
            // 
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(34, 261);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(31, 13);
            this.lPlan.TabIndex = 60;
            this.lPlan.Text = "Plan:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(96, 227);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(231, 21);
            this.cbEstadoCivil.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(31, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 43);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(89, 16);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 23;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(127, 151);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNacimiento.TabIndex = 57;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(81, 125);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(246, 20);
            this.tbTelefono.TabIndex = 56;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(185, 95);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(142, 20);
            this.tbDni.TabIndex = 55;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DNI"});
            this.cbTipo.Location = new System.Drawing.Point(81, 95);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(45, 21);
            this.cbTipo.TabIndex = 54;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(81, 66);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(246, 20);
            this.tbApellido.TabIndex = 53;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(81, 36);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(246, 20);
            this.tbNombre.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Fecha Nacimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre:";
            // 
            // lmatricula
            // 
            this.lmatricula.AutoSize = true;
            this.lmatricula.Location = new System.Drawing.Point(28, 294);
            this.lmatricula.Name = "lmatricula";
            this.lmatricula.Size = new System.Drawing.Size(53, 13);
            this.lmatricula.TabIndex = 63;
            this.lmatricula.Text = "Matricula:";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(96, 291);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(231, 20);
            this.tbMatricula.TabIndex = 64;
            // 
            // FormAltaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 463);
            this.Name = "FormAltaProfesional";
            this.Text = "Form1";
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSearchPlan;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label lPlan;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label lmatricula;

    }
}