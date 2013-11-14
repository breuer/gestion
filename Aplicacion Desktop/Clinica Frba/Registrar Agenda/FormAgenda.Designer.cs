namespace Clinica_Frba.NewFolder2
{
    partial class FormAgenda
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
            this.gbProfesionaDatos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSeleccionarProfesional = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHorasTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diaAgenda4 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda3 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda2 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda1 = new Clinica_Frba.DiaAgenda();
            this.diaMartes = new Clinica_Frba.DiaAgenda();
            this.diaLunes = new Clinica_Frba.DiaAgenda();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btGenerar = new System.Windows.Forms.Button();
            this.gbProfesionaDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfesionaDatos
            // 
            this.gbProfesionaDatos.Controls.Add(this.groupBox1);
            this.gbProfesionaDatos.Controls.Add(this.groupBox2);
            this.gbProfesionaDatos.Location = new System.Drawing.Point(12, 12);
            this.gbProfesionaDatos.Name = "gbProfesionaDatos";
            this.gbProfesionaDatos.Size = new System.Drawing.Size(871, 476);
            this.gbProfesionaDatos.TabIndex = 0;
            this.gbProfesionaDatos.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btSeleccionarProfesional);
            this.groupBox2.Location = new System.Drawing.Point(19, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesional";
            // 
            // btSeleccionarProfesional
            // 
            this.btSeleccionarProfesional.Location = new System.Drawing.Point(765, 16);
            this.btSeleccionarProfesional.Name = "btSeleccionarProfesional";
            this.btSeleccionarProfesional.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionarProfesional.TabIndex = 0;
            this.btSeleccionarProfesional.Text = "Seleccionar";
            this.btSeleccionarProfesional.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(59, 16);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(246, 20);
            this.tbNombre.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre:";
            // 
            // tbHorasTotal
            // 
            this.tbHorasTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHorasTotal.Location = new System.Drawing.Point(6, 19);
            this.tbHorasTotal.Name = "tbHorasTotal";
            this.tbHorasTotal.Size = new System.Drawing.Size(825, 20);
            this.tbHorasTotal.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGenerar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.diaAgenda4);
            this.groupBox1.Controls.Add(this.diaAgenda3);
            this.groupBox1.Controls.Add(this.diaAgenda2);
            this.groupBox1.Controls.Add(this.diaAgenda1);
            this.groupBox1.Controls.Add(this.diaMartes);
            this.groupBox1.Controls.Add(this.diaLunes);
            this.groupBox1.Controls.Add(this.tbHorasTotal);
            this.groupBox1.Location = new System.Drawing.Point(19, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas Semanles";
            // 
            // diaAgenda4
            // 
            this.diaAgenda4.ButtonText = "Add Savado";
            this.diaAgenda4.Day = ((short)(7));
            this.diaAgenda4.Enabled = false;
            this.diaAgenda4.Location = new System.Drawing.Point(699, 45);
            this.diaAgenda4.Name = "diaAgenda4";
            this.diaAgenda4.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda4.TabIndex = 8;
            this.diaAgenda4.Titulo = "Savado";
            this.diaAgenda4.Load += new System.EventHandler(this.diaAgenda4_Load);
            // 
            // diaAgenda3
            // 
            this.diaAgenda3.ButtonText = "Add Viernes";
            this.diaAgenda3.Day = ((short)(6));
            this.diaAgenda3.Enabled = false;
            this.diaAgenda3.Location = new System.Drawing.Point(561, 45);
            this.diaAgenda3.Name = "diaAgenda3";
            this.diaAgenda3.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda3.TabIndex = 7;
            this.diaAgenda3.Titulo = "Viernes";
            // 
            // diaAgenda2
            // 
            this.diaAgenda2.ButtonText = "Add Jueves";
            this.diaAgenda2.Day = ((short)(5));
            this.diaAgenda2.Enabled = false;
            this.diaAgenda2.Location = new System.Drawing.Point(423, 45);
            this.diaAgenda2.Name = "diaAgenda2";
            this.diaAgenda2.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda2.TabIndex = 6;
            this.diaAgenda2.Titulo = "Jueves";
            // 
            // diaAgenda1
            // 
            this.diaAgenda1.ButtonText = "Add Miercoles";
            this.diaAgenda1.Day = ((short)(4));
            this.diaAgenda1.Enabled = false;
            this.diaAgenda1.Location = new System.Drawing.Point(285, 45);
            this.diaAgenda1.Name = "diaAgenda1";
            this.diaAgenda1.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda1.TabIndex = 5;
            this.diaAgenda1.Titulo = "Miercoles";
            // 
            // diaMartes
            // 
            this.diaMartes.ButtonText = "Add Martes";
            this.diaMartes.Day = ((short)(3));
            this.diaMartes.Enabled = false;
            this.diaMartes.Location = new System.Drawing.Point(147, 45);
            this.diaMartes.Name = "diaMartes";
            this.diaMartes.Size = new System.Drawing.Size(132, 280);
            this.diaMartes.TabIndex = 4;
            this.diaMartes.Titulo = "Martes";
            // 
            // diaLunes
            // 
            this.diaLunes.ButtonText = "Add Lunes";
            this.diaLunes.Day = ((short)(2));
            this.diaLunes.Enabled = false;
            this.diaLunes.Location = new System.Drawing.Point(9, 45);
            this.diaLunes.Name = "diaLunes";
            this.diaLunes.Size = new System.Drawing.Size(132, 280);
            this.diaLunes.TabIndex = 3;
            this.diaLunes.Titulo = "Lunes ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Desde:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(98, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(98, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Hasta:";
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(423, 325);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 21);
            this.cbDias.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Perido Agenda:";
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(699, 346);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(132, 23);
            this.btGenerar.TabIndex = 15;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 500);
            this.Controls.Add(this.gbProfesionaDatos);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.gbProfesionaDatos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfesionaDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSeleccionarProfesional;
        private System.Windows.Forms.TextBox tbHorasTotal;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DiaAgenda diaAgenda4;
        private DiaAgenda diaAgenda3;
        private DiaAgenda diaAgenda2;
        private DiaAgenda diaAgenda1;
        private DiaAgenda diaMartes;
        private DiaAgenda diaLunes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}