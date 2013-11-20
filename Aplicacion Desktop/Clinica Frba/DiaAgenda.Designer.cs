namespace Clinica_Frba
{
    partial class DiaAgenda
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb = new System.Windows.Forms.GroupBox();
            this.btSubtract = new System.Windows.Forms.Button();
            this.lbCantHoras = new System.Windows.Forms.Label();
            this.lbCantTurnos = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.cbHoraFinal = new System.Windows.Forms.ComboBox();
            this.cbHoraInicial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCantTurnos11 = new System.Windows.Forms.Label();
            this.lbHorFin = new System.Windows.Forms.Label();
            this.lbHoraF0 = new System.Windows.Forms.Label();
            this.btDia = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb.Controls.Add(this.btSubtract);
            this.gb.Controls.Add(this.lbCantHoras);
            this.gb.Controls.Add(this.lbCantTurnos);
            this.gb.Controls.Add(this.btReset);
            this.gb.Controls.Add(this.cbHoraFinal);
            this.gb.Controls.Add(this.cbHoraInicial);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.lbCantTurnos11);
            this.gb.Controls.Add(this.lbHorFin);
            this.gb.Controls.Add(this.lbHoraF0);
            this.gb.Controls.Add(this.btDia);
            this.gb.Location = new System.Drawing.Point(3, 3);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(124, 268);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "titulo";
            // 
            // btSubtract
            // 
            this.btSubtract.BackColor = System.Drawing.Color.Cyan;
            this.btSubtract.Location = new System.Drawing.Point(6, 19);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(111, 71);
            this.btSubtract.TabIndex = 13;
            this.btSubtract.Text = "ButtonSubtractText";
            this.btSubtract.UseVisualStyleBackColor = false;
            this.btSubtract.Visible = false;
            this.btSubtract.Click += new System.EventHandler(this.btSubtract_Click);
            // 
            // lbCantHoras
            // 
            this.lbCantHoras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCantHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCantHoras.Location = new System.Drawing.Point(73, 201);
            this.lbCantHoras.Name = "lbCantHoras";
            this.lbCantHoras.Size = new System.Drawing.Size(41, 23);
            this.lbCantHoras.TabIndex = 12;
            // 
            // lbCantTurnos
            // 
            this.lbCantTurnos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCantTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCantTurnos.Location = new System.Drawing.Point(10, 201);
            this.lbCantTurnos.Name = "lbCantTurnos";
            this.lbCantTurnos.Size = new System.Drawing.Size(40, 23);
            this.lbCantTurnos.TabIndex = 11;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(10, 239);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(107, 23);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "Clear";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // cbHoraFinal
            // 
            this.cbHoraFinal.FormattingEnabled = true;
            this.cbHoraFinal.Location = new System.Drawing.Point(10, 160);
            this.cbHoraFinal.Name = "cbHoraFinal";
            this.cbHoraFinal.Size = new System.Drawing.Size(107, 21);
            this.cbHoraFinal.TabIndex = 10;
            this.cbHoraFinal.SelectionChangeCommitted += new System.EventHandler(this.cbHoraFinal_SelectionChangeCommitted);
            // 
            // cbHoraInicial
            // 
            this.cbHoraInicial.FormattingEnabled = true;
            this.cbHoraInicial.Location = new System.Drawing.Point(10, 117);
            this.cbHoraInicial.Name = "cbHoraInicial";
            this.cbHoraInicial.Size = new System.Drawing.Size(107, 21);
            this.cbHoraInicial.TabIndex = 1;
            this.cbHoraInicial.SelectionChangeCommitted += new System.EventHandler(this.cbHoraInicial_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Horas";
            // 
            // lbCantTurnos11
            // 
            this.lbCantTurnos11.AutoSize = true;
            this.lbCantTurnos11.Location = new System.Drawing.Point(7, 184);
            this.lbCantTurnos11.Name = "lbCantTurnos11";
            this.lbCantTurnos11.Size = new System.Drawing.Size(40, 13);
            this.lbCantTurnos11.TabIndex = 6;
            this.lbCantTurnos11.Text = "Turnos";
            // 
            // lbHorFin
            // 
            this.lbHorFin.AutoSize = true;
            this.lbHorFin.Location = new System.Drawing.Point(7, 141);
            this.lbHorFin.Name = "lbHorFin";
            this.lbHorFin.Size = new System.Drawing.Size(50, 13);
            this.lbHorFin.TabIndex = 4;
            this.lbHorFin.Text = "Hora Fin:";
            // 
            // lbHoraF0
            // 
            this.lbHoraF0.AutoSize = true;
            this.lbHoraF0.Location = new System.Drawing.Point(7, 97);
            this.lbHoraF0.Name = "lbHoraF0";
            this.lbHoraF0.Size = new System.Drawing.Size(61, 13);
            this.lbHoraF0.TabIndex = 3;
            this.lbHoraF0.Text = "Hora Inicio:";
            // 
            // btDia
            // 
            this.btDia.Location = new System.Drawing.Point(6, 19);
            this.btDia.Name = "btDia";
            this.btDia.Size = new System.Drawing.Size(111, 71);
            this.btDia.TabIndex = 0;
            this.btDia.Text = "ButtonText";
            this.btDia.UseVisualStyleBackColor = true;
            this.btDia.Click += new System.EventHandler(this.btDia_Click);
            // 
            // DiaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Name = "DiaAgenda";
            this.Size = new System.Drawing.Size(132, 280);
            this.Load += new System.EventHandler(this.DiaAgenda_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCantTurnos11;
        private System.Windows.Forms.Label lbHorFin;
        private System.Windows.Forms.Label lbHoraF0;
        private System.Windows.Forms.Button btDia;
        private System.Windows.Forms.Label lbCantHoras;
        private System.Windows.Forms.Label lbCantTurnos;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.ComboBox cbHoraFinal;
        private System.Windows.Forms.ComboBox cbHoraInicial;
        private System.Windows.Forms.Button btSubtract;
    }
}
