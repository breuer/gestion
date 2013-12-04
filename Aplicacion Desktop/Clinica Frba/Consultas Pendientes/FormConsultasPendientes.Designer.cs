namespace Clinica_Frba.Consultas_Pendientes
{
    partial class FormConsultasPendientes
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
            this.lvConsultasPendientes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtenderConsulta = new System.Windows.Forms.Button();
            this.dtpFechaConsultas = new System.Windows.Forms.DateTimePicker();
            this.btCargarConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultasPendientes
            // 
            this.lvConsultasPendientes.Location = new System.Drawing.Point(42, 118);
            this.lvConsultasPendientes.Name = "lvConsultasPendientes";
            this.lvConsultasPendientes.Size = new System.Drawing.Size(508, 216);
            this.lvConsultasPendientes.TabIndex = 0;
            this.lvConsultasPendientes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha consultas pendientes:";
            // 
            // btAtenderConsulta
            // 
            this.btAtenderConsulta.Location = new System.Drawing.Point(442, 353);
            this.btAtenderConsulta.Name = "btAtenderConsulta";
            this.btAtenderConsulta.Size = new System.Drawing.Size(108, 23);
            this.btAtenderConsulta.TabIndex = 2;
            this.btAtenderConsulta.Text = "Atender consulta";
            this.btAtenderConsulta.UseVisualStyleBackColor = true;
            this.btAtenderConsulta.Click += new System.EventHandler(this.btAtenderConsulta_Click);
            // 
            // dtpFechaConsultas
            // 
            this.dtpFechaConsultas.Location = new System.Drawing.Point(185, 54);
            this.dtpFechaConsultas.Name = "dtpFechaConsultas";
            this.dtpFechaConsultas.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaConsultas.TabIndex = 3;
            // 
            // btCargarConsultas
            // 
            this.btCargarConsultas.Location = new System.Drawing.Point(442, 54);
            this.btCargarConsultas.Name = "btCargarConsultas";
            this.btCargarConsultas.Size = new System.Drawing.Size(108, 23);
            this.btCargarConsultas.TabIndex = 4;
            this.btCargarConsultas.Text = "Cargar consultas";
            this.btCargarConsultas.UseVisualStyleBackColor = true;
            this.btCargarConsultas.Click += new System.EventHandler(this.btCargarConsultas_Click);
            // 
            // FormConsultasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.btCargarConsultas);
            this.Controls.Add(this.dtpFechaConsultas);
            this.Controls.Add(this.btAtenderConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvConsultasPendientes);
            this.Name = "FormConsultasPendientes";
            this.Text = "FormConsulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultasPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtenderConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaConsultas;
        private System.Windows.Forms.Button btCargarConsultas;
    }
}