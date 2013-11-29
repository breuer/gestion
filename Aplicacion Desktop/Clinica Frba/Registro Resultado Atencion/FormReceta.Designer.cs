namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class FormReceta
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
            this.btAddMedicamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMedicamento = new System.Windows.Forms.TextBox();
            this.lbListaMedicamentos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btCargarBonoFarmacia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNroBono = new System.Windows.Forms.TextBox();
            this.gbAgregarMedicamento = new System.Windows.Forms.GroupBox();
            this.gbAgregarMedicamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddMedicamento
            // 
            this.btAddMedicamento.Location = new System.Drawing.Point(272, 104);
            this.btAddMedicamento.Name = "btAddMedicamento";
            this.btAddMedicamento.Size = new System.Drawing.Size(170, 23);
            this.btAddMedicamento.TabIndex = 0;
            this.btAddMedicamento.Text = "Agregar medicamento";
            this.btAddMedicamento.UseVisualStyleBackColor = true;
            this.btAddMedicamento.Click += new System.EventHandler(this.btAddMedicamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicamento";
            // 
            // tbMedicamento
            // 
            this.tbMedicamento.Location = new System.Drawing.Point(99, 38);
            this.tbMedicamento.Multiline = true;
            this.tbMedicamento.Name = "tbMedicamento";
            this.tbMedicamento.Size = new System.Drawing.Size(629, 27);
            this.tbMedicamento.TabIndex = 2;
            // 
            // lbListaMedicamentos
            // 
            this.lbListaMedicamentos.FormattingEnabled = true;
            this.lbListaMedicamentos.Location = new System.Drawing.Point(21, 292);
            this.lbListaMedicamentos.Name = "lbListaMedicamentos";
            this.lbListaMedicamentos.Size = new System.Drawing.Size(707, 238);
            this.lbListaMedicamentos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(99, 106);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 5;
            // 
            // btCargarBonoFarmacia
            // 
            this.btCargarBonoFarmacia.Location = new System.Drawing.Point(270, 47);
            this.btCargarBonoFarmacia.Name = "btCargarBonoFarmacia";
            this.btCargarBonoFarmacia.Size = new System.Drawing.Size(150, 23);
            this.btCargarBonoFarmacia.TabIndex = 6;
            this.btCargarBonoFarmacia.Text = "Cargar bono farmacia";
            this.btCargarBonoFarmacia.UseVisualStyleBackColor = true;
            this.btCargarBonoFarmacia.Click += new System.EventHandler(this.btCargarBonoFarmacia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bono farmacia";
            // 
            // tbNroBono
            // 
            this.tbNroBono.Location = new System.Drawing.Point(138, 47);
            this.tbNroBono.Name = "tbNroBono";
            this.tbNroBono.Size = new System.Drawing.Size(100, 20);
            this.tbNroBono.TabIndex = 8;
            // 
            // gbAgregarMedicamento
            // 
            this.gbAgregarMedicamento.Controls.Add(this.btAddMedicamento);
            this.gbAgregarMedicamento.Controls.Add(this.label2);
            this.gbAgregarMedicamento.Controls.Add(this.tbCantidad);
            this.gbAgregarMedicamento.Controls.Add(this.label1);
            this.gbAgregarMedicamento.Controls.Add(this.tbMedicamento);
            this.gbAgregarMedicamento.Location = new System.Drawing.Point(12, 108);
            this.gbAgregarMedicamento.Name = "gbAgregarMedicamento";
            this.gbAgregarMedicamento.Size = new System.Drawing.Size(766, 144);
            this.gbAgregarMedicamento.TabIndex = 9;
            this.gbAgregarMedicamento.TabStop = false;
            this.gbAgregarMedicamento.Text = "groupBox1";
            // 
            // FormReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 595);
            this.Controls.Add(this.gbAgregarMedicamento);
            this.Controls.Add(this.tbNroBono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCargarBonoFarmacia);
            this.Controls.Add(this.lbListaMedicamentos);
            this.Name = "FormReceta";
            this.Text = "FormReceta";
            this.Load += new System.EventHandler(this.FormReceta_Load);
            this.gbAgregarMedicamento.ResumeLayout(false);
            this.gbAgregarMedicamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMedicamento;
        private System.Windows.Forms.ListBox lbListaMedicamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btCargarBonoFarmacia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNroBono;
        private System.Windows.Forms.GroupBox gbAgregarMedicamento;
    }
}