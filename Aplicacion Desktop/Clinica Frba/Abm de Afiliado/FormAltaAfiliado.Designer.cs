namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class FormAltaAfiliado
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbQuitarConyuge = new System.Windows.Forms.Button();
            this.btAddFamiliar = new System.Windows.Forms.Button();
            this.dgvFamiliares = new System.Windows.Forms.DataGridView();
            this.btAddConyuge = new System.Windows.Forms.Button();
            this.dgvConyuge = new System.Windows.Forms.DataGridView();
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
            this.btAdd = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConyuge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.tbMail);
            this.gbControl.Controls.Add(this.lMail);
            this.gbControl.Controls.Add(this.lDireccion);
            this.gbControl.Controls.Add(this.tbDireccion);
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
            this.gbControl.Size = new System.Drawing.Size(331, 326);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbQuitarConyuge);
            this.groupBox3.Controls.Add(this.btAddFamiliar);
            this.groupBox3.Controls.Add(this.dgvFamiliares);
            this.groupBox3.Controls.Add(this.btAddConyuge);
            this.groupBox3.Controls.Add(this.dgvConyuge);
            this.groupBox3.Location = new System.Drawing.Point(349, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 292);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dependientes";
            // 
            // cbQuitarConyuge
            // 
            this.cbQuitarConyuge.Enabled = false;
            this.cbQuitarConyuge.Location = new System.Drawing.Point(167, 58);
            this.cbQuitarConyuge.Name = "cbQuitarConyuge";
            this.cbQuitarConyuge.Size = new System.Drawing.Size(140, 23);
            this.cbQuitarConyuge.TabIndex = 4;
            this.cbQuitarConyuge.Text = "Quitar conyuge";
            this.cbQuitarConyuge.UseVisualStyleBackColor = true;
            // 
            // btAddFamiliar
            // 
            this.btAddFamiliar.Enabled = false;
            this.btAddFamiliar.Location = new System.Drawing.Point(313, 263);
            this.btAddFamiliar.Name = "btAddFamiliar";
            this.btAddFamiliar.Size = new System.Drawing.Size(140, 23);
            this.btAddFamiliar.TabIndex = 3;
            this.btAddFamiliar.Text = "Agregar familiar";
            this.btAddFamiliar.UseVisualStyleBackColor = true;
            // 
            // dgvFamiliares
            // 
            this.dgvFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliares.Location = new System.Drawing.Point(7, 94);
            this.dgvFamiliares.Name = "dgvFamiliares";
            this.dgvFamiliares.Size = new System.Drawing.Size(446, 166);
            this.dgvFamiliares.TabIndex = 2;
            // 
            // btAddConyuge
            // 
            this.btAddConyuge.Enabled = false;
            this.btAddConyuge.Location = new System.Drawing.Point(313, 58);
            this.btAddConyuge.Name = "btAddConyuge";
            this.btAddConyuge.Size = new System.Drawing.Size(140, 23);
            this.btAddConyuge.TabIndex = 1;
            this.btAddConyuge.Text = "Agregar conyuge";
            this.btAddConyuge.UseVisualStyleBackColor = true;
            this.btAddConyuge.Click += new System.EventHandler(this.btAddConyuge_Click);
            // 
            // dgvConyuge
            // 
            this.dgvConyuge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConyuge.Location = new System.Drawing.Point(7, 19);
            this.dgvConyuge.Name = "dgvConyuge";
            this.dgvConyuge.Size = new System.Drawing.Size(446, 33);
            this.dgvConyuge.TabIndex = 0;
            // 
            // btSearchPlan
            // 
            this.btSearchPlan.Location = new System.Drawing.Point(230, 244);
            this.btSearchPlan.Name = "btSearchPlan";
            this.btSearchPlan.Size = new System.Drawing.Size(75, 23);
            this.btSearchPlan.TabIndex = 44;
            this.btSearchPlan.Text = "Buscar";
            this.btSearchPlan.UseVisualStyleBackColor = true;
            this.btSearchPlan.Click += new System.EventHandler(this.btSearchPlan_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(74, 244);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(150, 21);
            this.cbPlan.TabIndex = 43;
            // 
            // lPlan
            // 
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(12, 244);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(31, 13);
            this.lPlan.TabIndex = 42;
            this.lPlan.Text = "Plan:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(74, 210);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(231, 21);
            this.cbEstadoCivil.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(9, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 43);
            this.groupBox2.TabIndex = 40;
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
            this.dtFechaNacimiento.Location = new System.Drawing.Point(105, 134);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNacimiento.TabIndex = 39;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(59, 108);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(246, 20);
            this.tbTelefono.TabIndex = 38;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(163, 78);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(142, 20);
            this.tbDni.TabIndex = 37;
            this.tbDni.Leave += new System.EventHandler(this.tbDni_Leave);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DNI"});
            this.cbTipo.Location = new System.Drawing.Point(59, 78);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(45, 21);
            this.cbTipo.TabIndex = 36;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(59, 49);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(246, 20);
            this.tbApellido.TabIndex = 35;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(59, 19);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(246, 20);
            this.tbNombre.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Fecha Nacimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(263, 434);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 17;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(74, 303);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(231, 20);
            this.tbMail.TabIndex = 72;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(6, 303);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(32, 13);
            this.lMail.TabIndex = 71;
            this.lMail.Text = "Mail: ";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(6, 273);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(55, 13);
            this.lDireccion.TabIndex = 70;
            this.lDireccion.Text = "Direccion:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(74, 273);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(231, 20);
            this.tbDireccion.TabIndex = 69;
            // 
            // FormAltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btAdd);
            this.Name = "FormAltaAfiliado";
            this.Text = "Alta Afiliado";
            this.Controls.SetChildIndex(this.btAdd, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btAccion, 0);
            this.Controls.SetChildIndex(this.btLimpiar, 0);
            this.Controls.SetChildIndex(this.gbControl, 0);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConyuge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddFamiliar;
        private System.Windows.Forms.DataGridView dgvFamiliares;
        private System.Windows.Forms.Button btAddConyuge;
        private System.Windows.Forms.DataGridView dgvConyuge;
        private System.Windows.Forms.Button btSearchPlan;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label lPlan;
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
        private System.Windows.Forms.Button cbQuitarConyuge;
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox tbDireccion;

    }
}