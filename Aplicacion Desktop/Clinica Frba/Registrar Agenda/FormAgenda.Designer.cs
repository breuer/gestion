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
            this.diaLunes = new Clinica_Frba.DiaAgenda();
            this.diaMartes = new Clinica_Frba.DiaAgenda();
            this.diaAgenda1 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda2 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda3 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda4 = new Clinica_Frba.DiaAgenda();
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
            this.groupBox2.Size = new System.Drawing.Size(846, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesional";
            // 
            // btSeleccionarProfesional
            // 
            this.btSeleccionarProfesional.Location = new System.Drawing.Point(765, 53);
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
            this.groupBox1.Controls.Add(this.diaAgenda4);
            this.groupBox1.Controls.Add(this.diaAgenda3);
            this.groupBox1.Controls.Add(this.diaAgenda2);
            this.groupBox1.Controls.Add(this.diaAgenda1);
            this.groupBox1.Controls.Add(this.diaMartes);
            this.groupBox1.Controls.Add(this.diaLunes);
            this.groupBox1.Controls.Add(this.tbHorasTotal);
            this.groupBox1.Location = new System.Drawing.Point(19, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // diaLunes
            // 
            this.diaLunes.ButtonText = "Add Lunes";
            this.diaLunes.Day = ((short)(2));
            this.diaLunes.Location = new System.Drawing.Point(9, 58);
            this.diaLunes.Name = "diaLunes";
            this.diaLunes.Size = new System.Drawing.Size(132, 280);
            this.diaLunes.TabIndex = 3;
            this.diaLunes.Titulo = "Lunes ";
            // 
            // diaMartes
            // 
            this.diaMartes.ButtonText = "Add Martes";
            this.diaMartes.Day = ((short)(3));
            this.diaMartes.Location = new System.Drawing.Point(147, 58);
            this.diaMartes.Name = "diaMartes";
            this.diaMartes.Size = new System.Drawing.Size(132, 280);
            this.diaMartes.TabIndex = 4;
            this.diaMartes.Titulo = "Martes";
            // 
            // diaAgenda1
            // 
            this.diaAgenda1.ButtonText = "Add Miercoles";
            this.diaAgenda1.Day = ((short)(4));
            this.diaAgenda1.Location = new System.Drawing.Point(285, 58);
            this.diaAgenda1.Name = "diaAgenda1";
            this.diaAgenda1.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda1.TabIndex = 5;
            this.diaAgenda1.Titulo = "Miercoles";
            // 
            // diaAgenda2
            // 
            this.diaAgenda2.ButtonText = "Add Jueves";
            this.diaAgenda2.Day = ((short)(5));
            this.diaAgenda2.Location = new System.Drawing.Point(423, 58);
            this.diaAgenda2.Name = "diaAgenda2";
            this.diaAgenda2.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda2.TabIndex = 6;
            this.diaAgenda2.Titulo = "Jueves";
            // 
            // diaAgenda3
            // 
            this.diaAgenda3.ButtonText = "Add Viernes";
            this.diaAgenda3.Day = ((short)(6));
            this.diaAgenda3.Location = new System.Drawing.Point(561, 58);
            this.diaAgenda3.Name = "diaAgenda3";
            this.diaAgenda3.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda3.TabIndex = 7;
            this.diaAgenda3.Titulo = "Viernes";
            // 
            // diaAgenda4
            // 
            this.diaAgenda4.ButtonText = "Add Savado";
            this.diaAgenda4.Day = ((short)(7));
            this.diaAgenda4.Location = new System.Drawing.Point(699, 58);
            this.diaAgenda4.Name = "diaAgenda4";
            this.diaAgenda4.Size = new System.Drawing.Size(132, 280);
            this.diaAgenda4.TabIndex = 8;
            this.diaAgenda4.Titulo = "Savado";
            this.diaAgenda4.Load += new System.EventHandler(this.diaAgenda4_Load);
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
    }
}