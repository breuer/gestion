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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diaSabado = new Clinica_Frba.DiaAgenda();
            this.diaViernes = new Clinica_Frba.DiaAgenda();
            this.diaJueves = new Clinica_Frba.DiaAgenda();
            this.diaMiercoles = new Clinica_Frba.DiaAgenda();
            this.diaMartes = new Clinica_Frba.DiaAgenda();
            this.diaLunes = new Clinica_Frba.DiaAgenda();
            this.tbHorasTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProfesional = new System.Windows.Forms.DataGridView();
            this.btSeleccionarProfesional = new System.Windows.Forms.Button();
            this.gbProfesionaDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProfesionaDatos
            // 
            this.gbProfesionaDatos.Controls.Add(this.groupBox1);
            this.gbProfesionaDatos.Controls.Add(this.groupBox2);
            this.gbProfesionaDatos.Location = new System.Drawing.Point(12, 3);
            this.gbProfesionaDatos.Name = "gbProfesionaDatos";
            this.gbProfesionaDatos.Size = new System.Drawing.Size(871, 495);
            this.gbProfesionaDatos.TabIndex = 0;
            this.gbProfesionaDatos.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaFinal);
            this.groupBox1.Controls.Add(this.dtFechaDesde);
            this.groupBox1.Controls.Add(this.btGenerar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.diaSabado);
            this.groupBox1.Controls.Add(this.diaViernes);
            this.groupBox1.Controls.Add(this.diaJueves);
            this.groupBox1.Controls.Add(this.diaMiercoles);
            this.groupBox1.Controls.Add(this.diaMartes);
            this.groupBox1.Controls.Add(this.diaLunes);
            this.groupBox1.Controls.Add(this.tbHorasTotal);
            this.groupBox1.Location = new System.Drawing.Point(25, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas Semanles";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Enabled = false;
            this.dtFechaFinal.Location = new System.Drawing.Point(98, 356);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 17;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Location = new System.Drawing.Point(98, 326);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDesde.TabIndex = 16;
            this.dtFechaDesde.Leave += new System.EventHandler(this.dtFechaDesde_Leave);
            // 
            // btGenerar
            // 
            this.btGenerar.Enabled = false;
            this.btGenerar.Location = new System.Drawing.Point(699, 346);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(132, 23);
            this.btGenerar.TabIndex = 15;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Periodo Agenda:";
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(423, 325);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 21);
            this.cbDias.TabIndex = 13;
            this.cbDias.SelectionChangeCommitted += new System.EventHandler(this.cbDias_SelectionChangeCommitted);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Desde:";
            // 
            // diaSabado
            // 
            this.diaSabado.ButtonSubtractText = "ButtonSubtractText";
            this.diaSabado.ButtonText = "Add Sabado";
            this.diaSabado.Day = ((short)(7));
            this.diaSabado.Enabled = false;
            this.diaSabado.FormAnfitrion = null;
            this.diaSabado.Location = new System.Drawing.Point(699, 45);
            this.diaSabado.Name = "diaSabado";
            this.diaSabado.Size = new System.Drawing.Size(132, 280);
            this.diaSabado.TabIndex = 8;
            this.diaSabado.Titulo = "Sabado";
            // 
            // diaViernes
            // 
            this.diaViernes.ButtonSubtractText = "ButtonSubtractText";
            this.diaViernes.ButtonText = "Add Viernes";
            this.diaViernes.Day = ((short)(6));
            this.diaViernes.Enabled = false;
            this.diaViernes.FormAnfitrion = null;
            this.diaViernes.Location = new System.Drawing.Point(561, 45);
            this.diaViernes.Name = "diaViernes";
            this.diaViernes.Size = new System.Drawing.Size(132, 280);
            this.diaViernes.TabIndex = 7;
            this.diaViernes.Titulo = "Viernes";
            // 
            // diaJueves
            // 
            this.diaJueves.ButtonSubtractText = "ButtonSubtractText";
            this.diaJueves.ButtonText = "Add Jueves";
            this.diaJueves.Day = ((short)(5));
            this.diaJueves.Enabled = false;
            this.diaJueves.FormAnfitrion = null;
            this.diaJueves.Location = new System.Drawing.Point(423, 45);
            this.diaJueves.Name = "diaJueves";
            this.diaJueves.Size = new System.Drawing.Size(132, 280);
            this.diaJueves.TabIndex = 6;
            this.diaJueves.Titulo = "Jueves";
            // 
            // diaMiercoles
            // 
            this.diaMiercoles.ButtonSubtractText = "ButtonSubtractText";
            this.diaMiercoles.ButtonText = "Add Miercoles";
            this.diaMiercoles.Day = ((short)(4));
            this.diaMiercoles.Enabled = false;
            this.diaMiercoles.FormAnfitrion = null;
            this.diaMiercoles.Location = new System.Drawing.Point(285, 45);
            this.diaMiercoles.Name = "diaMiercoles";
            this.diaMiercoles.Size = new System.Drawing.Size(132, 280);
            this.diaMiercoles.TabIndex = 5;
            this.diaMiercoles.Titulo = "Miercoles";
            // 
            // diaMartes
            // 
            this.diaMartes.ButtonSubtractText = "ButtonSubtractText";
            this.diaMartes.ButtonText = "Add Martes";
            this.diaMartes.Day = ((short)(3));
            this.diaMartes.Enabled = false;
            this.diaMartes.FormAnfitrion = null;
            this.diaMartes.Location = new System.Drawing.Point(147, 45);
            this.diaMartes.Name = "diaMartes";
            this.diaMartes.Size = new System.Drawing.Size(132, 280);
            this.diaMartes.TabIndex = 4;
            this.diaMartes.Titulo = "Martes";
            // 
            // diaLunes
            // 
            this.diaLunes.ButtonSubtractText = "ButtonSubtractText";
            this.diaLunes.ButtonText = "Add Lunes";
            this.diaLunes.Day = ((short)(2));
            this.diaLunes.Enabled = false;
            this.diaLunes.FormAnfitrion = null;
            this.diaLunes.Location = new System.Drawing.Point(9, 45);
            this.diaLunes.Name = "diaLunes";
            this.diaLunes.Size = new System.Drawing.Size(132, 280);
            this.diaLunes.TabIndex = 3;
            this.diaLunes.Titulo = "Lunes ";
            // 
            // tbHorasTotal
            // 
            this.tbHorasTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHorasTotal.Location = new System.Drawing.Point(6, 19);
            this.tbHorasTotal.Name = "tbHorasTotal";
            this.tbHorasTotal.Size = new System.Drawing.Size(825, 20);
            this.tbHorasTotal.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProfesional);
            this.groupBox2.Controls.Add(this.btSeleccionarProfesional);
            this.groupBox2.Location = new System.Drawing.Point(19, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesional";
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Enabled = false;
            this.dgvProfesional.Location = new System.Drawing.Point(12, 13);
            this.dgvProfesional.Name = "dgvProfesional";
            this.dgvProfesional.Size = new System.Drawing.Size(710, 55);
            this.dgvProfesional.TabIndex = 1;
            // 
            // btSeleccionarProfesional
            // 
            this.btSeleccionarProfesional.Location = new System.Drawing.Point(765, 16);
            this.btSeleccionarProfesional.Name = "btSeleccionarProfesional";
            this.btSeleccionarProfesional.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionarProfesional.TabIndex = 0;
            this.btSeleccionarProfesional.Text = "Seleccionar";
            this.btSeleccionarProfesional.UseVisualStyleBackColor = true;
            this.btSeleccionarProfesional.Click += new System.EventHandler(this.btSeleccionarProfesional_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 500);
            this.Controls.Add(this.gbProfesionaDatos);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.gbProfesionaDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfesionaDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSeleccionarProfesional;
        private System.Windows.Forms.TextBox tbHorasTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private DiaAgenda diaSabado;
        private DiaAgenda diaViernes;
        private DiaAgenda diaJueves;
        private DiaAgenda diaMiercoles;
        private DiaAgenda diaMartes;
        private DiaAgenda diaLunes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.DataGridView dgvProfesional;
    }
}