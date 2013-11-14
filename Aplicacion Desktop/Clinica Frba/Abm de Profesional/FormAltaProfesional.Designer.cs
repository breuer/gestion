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
            this.gbSexo = new System.Windows.Forms.GroupBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lmatricula = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.dgvEspecialidadesMedicas = new System.Windows.Forms.DataGridView();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.tbMail);
            this.gbControl.Controls.Add(this.lMail);
            this.gbControl.Controls.Add(this.lDireccion);
            this.gbControl.Controls.Add(this.tbDireccion);
            this.gbControl.Controls.Add(this.tbMatricula);
            this.gbControl.Controls.Add(this.lmatricula);
            this.gbControl.Controls.Add(this.gbSexo);
            this.gbControl.Controls.Add(this.dtFechaNacimiento);
            this.gbControl.Controls.Add(this.tbTelefono);
            this.gbControl.Controls.Add(this.tbDni);
            this.gbControl.Controls.Add(this.cbTipo);
            this.gbControl.Controls.Add(this.tbApellido);
            this.gbControl.Controls.Add(this.tbNombre);
            this.gbControl.Controls.Add(this.label13);
            this.gbControl.Controls.Add(this.label12);
            this.gbControl.Controls.Add(this.label11);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Size = new System.Drawing.Size(353, 415);
            this.gbControl.Text = "Datos Personales";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Controls.Add(this.radioButton1);
            this.gbSexo.Location = new System.Drawing.Point(31, 177);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(172, 43);
            this.gbSexo.TabIndex = 58;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
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
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(185, 95);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(142, 20);
            this.tbDni.TabIndex = 55;
            this.tbDni.Leave += new System.EventHandler(this.tbDni_Leave);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
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
            this.lmatricula.Location = new System.Drawing.Point(28, 229);
            this.lmatricula.Name = "lmatricula";
            this.lmatricula.Size = new System.Drawing.Size(53, 13);
            this.lmatricula.TabIndex = 63;
            this.lmatricula.Text = "Matricula:";
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(96, 226);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(231, 20);
            this.tbMatricula.TabIndex = 64;
            this.tbMatricula.Leave += new System.EventHandler(this.tbMatricula_Leave);
            this.tbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(96, 252);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(231, 20);
            this.tbDireccion.TabIndex = 65;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(28, 252);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(55, 13);
            this.lDireccion.TabIndex = 66;
            this.lDireccion.Text = "Direccion:";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(28, 282);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(32, 13);
            this.lMail.TabIndex = 67;
            this.lMail.Text = "Mail: ";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(96, 282);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(231, 20);
            this.tbMail.TabIndex = 68;
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.btSeleccionar);
            this.gbEspecialidad.Controls.Add(this.dgvEspecialidadesMedicas);
            this.gbEspecialidad.Location = new System.Drawing.Point(410, 12);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(435, 220);
            this.gbEspecialidad.TabIndex = 5;
            this.gbEspecialidad.TabStop = false;
            this.gbEspecialidad.Text = "Especialidades medicas";
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(309, 177);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(120, 23);
            this.btSeleccionar.TabIndex = 1;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // dgvEspecialidadesMedicas
            // 
            this.dgvEspecialidadesMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesMedicas.Location = new System.Drawing.Point(7, 20);
            this.dgvEspecialidadesMedicas.Name = "dgvEspecialidadesMedicas";
            this.dgvEspecialidadesMedicas.Size = new System.Drawing.Size(422, 150);
            this.dgvEspecialidadesMedicas.TabIndex = 0;
            // 
            // FormAltaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 463);
            this.Controls.Add(this.gbEspecialidad);
            this.Name = "FormAltaProfesional";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.gbEspecialidad, 0);
            this.Controls.SetChildIndex(this.btAccion, 0);
            this.Controls.SetChildIndex(this.btLimpiar, 0);
            this.Controls.SetChildIndex(this.gbControl, 0);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEspecialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesMedicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label lmatricula;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.DataGridView dgvEspecialidadesMedicas;

    }
}