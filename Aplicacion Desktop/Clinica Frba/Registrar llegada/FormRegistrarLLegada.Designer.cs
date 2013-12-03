namespace Clinica_Frba.Registrar_llegada
{
    partial class FormRegistrarLLegada
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNroProfesional = new System.Windows.Forms.TextBox();
            this.tbNroAfiliado = new System.Windows.Forms.TextBox();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.lvTurnos = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroTipoAfiliado = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btRegistrarLLegada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro profesional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro usuario";
            // 
            // tbNroProfesional
            // 
            this.tbNroProfesional.Location = new System.Drawing.Point(124, 114);
            this.tbNroProfesional.Name = "tbNroProfesional";
            this.tbNroProfesional.Size = new System.Drawing.Size(100, 20);
            this.tbNroProfesional.TabIndex = 8;
            // 
            // tbNroAfiliado
            // 
            this.tbNroAfiliado.Location = new System.Drawing.Point(124, 149);
            this.tbNroAfiliado.Name = "tbNroAfiliado";
            this.tbNroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.tbNroAfiliado.TabIndex = 9;
            this.tbNroAfiliado.TextChanged += new System.EventHandler(this.tbNroAfiliado_TextChanged);
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(124, 23);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(200, 20);
            this.dtpCalendar.TabIndex = 13;
            // 
            // lvTurnos
            // 
            this.lvTurnos.Location = new System.Drawing.Point(26, 235);
            this.lvTurnos.Name = "lvTurnos";
            this.lvTurnos.Size = new System.Drawing.Size(645, 197);
            this.lvTurnos.TabIndex = 14;
            this.lvTurnos.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nro tipo afiliado";
            // 
            // tbNroTipoAfiliado
            // 
            this.tbNroTipoAfiliado.Location = new System.Drawing.Point(124, 187);
            this.tbNroTipoAfiliado.Name = "tbNroTipoAfiliado";
            this.tbNroTipoAfiliado.Size = new System.Drawing.Size(100, 20);
            this.tbNroTipoAfiliado.TabIndex = 16;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(583, 187);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 17;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btRegistrarLLegada
            // 
            this.btRegistrarLLegada.Location = new System.Drawing.Point(554, 450);
            this.btRegistrarLLegada.Name = "btRegistrarLLegada";
            this.btRegistrarLLegada.Size = new System.Drawing.Size(104, 23);
            this.btRegistrarLLegada.TabIndex = 18;
            this.btRegistrarLLegada.Text = "Seleccionar";
            this.btRegistrarLLegada.UseVisualStyleBackColor = true;
            this.btRegistrarLLegada.Click += new System.EventHandler(this.btRegistrarLLegada_Click);
            // 
            // FormRegistrarLLegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 483);
            this.Controls.Add(this.btRegistrarLLegada);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.tbNroTipoAfiliado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvTurnos);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.tbNroAfiliado);
            this.Controls.Add(this.tbNroProfesional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrarLLegada";
            this.Text = "FormRegistrarLLegada";
            this.Load += new System.EventHandler(this.FormRegistrarLLegada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNroProfesional;
        private System.Windows.Forms.TextBox tbNroAfiliado;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.ListView lvTurnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroTipoAfiliado;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btRegistrarLLegada;
    }
}