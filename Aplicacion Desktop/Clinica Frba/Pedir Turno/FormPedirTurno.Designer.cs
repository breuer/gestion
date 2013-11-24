namespace Clinica_Frba.NewFolder4
{
    partial class FormPedirTurno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTurnosByDia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFechas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProfesional = new System.Windows.Forms.DataGridView();
            this.btSeleccionarProfesional = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosByDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dgvTurnosByDia);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvFechas);
            this.groupBox3.Location = new System.Drawing.Point(6, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 362);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turnos disponibles";
            // 
            // dgvTurnosByDia
            // 
            this.dgvTurnosByDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosByDia.Location = new System.Drawing.Point(557, 38);
            this.dgvTurnosByDia.Name = "dgvTurnosByDia";
            this.dgvTurnosByDia.Size = new System.Drawing.Size(421, 273);
            this.dgvTurnosByDia.TabIndex = 2;
            this.dgvTurnosByDia.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTurnosByDia_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fechas disponibles:";
            // 
            // dgvFechas
            // 
            this.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechas.Location = new System.Drawing.Point(16, 38);
            this.dgvFechas.Name = "dgvFechas";
            this.dgvFechas.Size = new System.Drawing.Size(535, 273);
            this.dgvFechas.TabIndex = 0;
            this.dgvFechas.DoubleClick += new System.EventHandler(this.dgvFechas_DoubleClick);
            this.dgvFechas.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvFechas_RowPrePaint);
            this.dgvFechas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFechas_RowPostPaint);
            this.dgvFechas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFechas_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProfesional);
            this.groupBox2.Controls.Add(this.btSeleccionarProfesional);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesional";
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Enabled = false;
            this.dgvProfesional.Location = new System.Drawing.Point(16, 13);
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
            // FormPedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 491);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPedirTurno";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosByDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProfesional;
        private System.Windows.Forms.Button btSeleccionarProfesional;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTurnosByDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFechas;
        private System.Windows.Forms.Label label2;
    }
}