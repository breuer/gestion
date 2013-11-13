namespace Clinica_Frba
{
    partial class Form1
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
            this.btSearchPlanes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btSacarPrefijo = new System.Windows.Forms.Button();
            this.tbInicial = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.tbFinal2 = new System.Windows.Forms.TextBox();
            this.btTestTime = new System.Windows.Forms.Button();
            this.btTestFechas = new System.Windows.Forms.Button();
            this.diaAgenda2 = new Clinica_Frba.DiaAgenda();
            this.diaAgenda1 = new Clinica_Frba.DiaAgenda();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sasas";
            // 
            // btSearchPlanes
            // 
            this.btSearchPlanes.Location = new System.Drawing.Point(247, 85);
            this.btSearchPlanes.Name = "btSearchPlanes";
            this.btSearchPlanes.Size = new System.Drawing.Size(75, 23);
            this.btSearchPlanes.TabIndex = 1;
            this.btSearchPlanes.Text = "searchPlanes";
            this.btSearchPlanes.UseVisualStyleBackColor = true;
            this.btSearchPlanes.Click += new System.EventHandler(this.btSearchPlanes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-26, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "serach Palnes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Test Conver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(361, 171);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(200, 20);
            this.dpFecha.TabIndex = 7;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(361, 38);
            this.tbFecha.Multiline = true;
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(200, 68);
            this.tbFecha.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "TestFecha";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btSacarPrefijo
            // 
            this.btSacarPrefijo.Location = new System.Drawing.Point(467, 112);
            this.btSacarPrefijo.Name = "btSacarPrefijo";
            this.btSacarPrefijo.Size = new System.Drawing.Size(75, 23);
            this.btSacarPrefijo.TabIndex = 10;
            this.btSacarPrefijo.Text = "SacarPrefijo";
            this.btSacarPrefijo.UseVisualStyleBackColor = true;
            this.btSacarPrefijo.Click += new System.EventHandler(this.btSacarPrefijo_Click);
            // 
            // tbInicial
            // 
            this.tbInicial.Location = new System.Drawing.Point(361, 114);
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.Size = new System.Drawing.Size(100, 20);
            this.tbInicial.TabIndex = 11;
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(548, 114);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFinal.TabIndex = 12;
            // 
            // tbFinal2
            // 
            this.tbFinal2.Location = new System.Drawing.Point(665, 114);
            this.tbFinal2.Name = "tbFinal2";
            this.tbFinal2.Size = new System.Drawing.Size(100, 20);
            this.tbFinal2.TabIndex = 13;
            // 
            // btTestTime
            // 
            this.btTestTime.Location = new System.Drawing.Point(665, 172);
            this.btTestTime.Name = "btTestTime";
            this.btTestTime.Size = new System.Drawing.Size(75, 23);
            this.btTestTime.TabIndex = 15;
            this.btTestTime.Text = "Time";
            this.btTestTime.UseVisualStyleBackColor = true;
            this.btTestTime.Click += new System.EventHandler(this.btTestTime_Click);
            // 
            // btTestFechas
            // 
            this.btTestFechas.Location = new System.Drawing.Point(573, 241);
            this.btTestFechas.Name = "btTestFechas";
            this.btTestFechas.Size = new System.Drawing.Size(75, 23);
            this.btTestFechas.TabIndex = 18;
            this.btTestFechas.Text = "Test Fechas";
            this.btTestFechas.UseVisualStyleBackColor = true;
            // 
            // diaAgenda2
            // 
            this.diaAgenda2.ButtonText = "ButtonText";
            this.diaAgenda2.Day = ((short)(2));
            this.diaAgenda2.Location = new System.Drawing.Point(247, 222);
            this.diaAgenda2.Name = "diaAgenda2";
            this.diaAgenda2.Size = new System.Drawing.Size(164, 280);
            this.diaAgenda2.TabIndex = 20;
            this.diaAgenda2.Titulo = "titulo";
            // 
            // diaAgenda1
            // 
            this.diaAgenda1.ButtonText = "ButtonText";
            this.diaAgenda1.Day = ((short)(2));
            this.diaAgenda1.Location = new System.Drawing.Point(50, 222);
            this.diaAgenda1.Name = "diaAgenda1";
            this.diaAgenda1.Size = new System.Drawing.Size(164, 280);
            this.diaAgenda1.TabIndex = 19;
            this.diaAgenda1.Titulo = "HOla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 514);
            this.Controls.Add(this.diaAgenda2);
            this.Controls.Add(this.diaAgenda1);
            this.Controls.Add(this.btTestFechas);
            this.Controls.Add(this.btTestTime);
            this.Controls.Add(this.tbFinal2);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbInicial);
            this.Controls.Add(this.btSacarPrefijo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSearchPlanes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearchPlanes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btSacarPrefijo;
        private System.Windows.Forms.TextBox tbInicial;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.TextBox tbFinal2;
        private System.Windows.Forms.Button btTestTime;
        private System.Windows.Forms.Button btTestFechas;
        private DiaAgenda diaAgenda1;
        private DiaAgenda diaAgenda2;
    }
}

