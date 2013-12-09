namespace Clinica_Frba.Cancelar_Atencion
{
    partial class FormCancelarAtencion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paAfiliado = new System.Windows.Forms.Panel();
            this.gbTurnos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpHasta = new System.Windows.Forms.DateTimePicker();
            this.dpDesde = new System.Windows.Forms.DateTimePicker();
            this.plBotones = new System.Windows.Forms.Panel();
            this.btTodos = new System.Windows.Forms.Button();
            this.btPerdidos = new System.Windows.Forms.Button();
            this.btCancelados = new System.Windows.Forms.Button();
            this.btFuturos = new System.Windows.Forms.Button();
            this.btAsistidos = new System.Windows.Forms.Button();
            this.dgwTurnos = new System.Windows.Forms.DataGridView();
            this.tbDatosTurnos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paAfiliado.SuspendLayout();
            this.gbTurnos.SuspendLayout();
            this.plBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // paAfiliado
            // 
            this.paAfiliado.Controls.Add(this.gbTurnos);
            this.paAfiliado.Location = new System.Drawing.Point(12, 12);
            this.paAfiliado.Name = "paAfiliado";
            this.paAfiliado.Size = new System.Drawing.Size(899, 570);
            this.paAfiliado.TabIndex = 0;
            // 
            // gbTurnos
            // 
            this.gbTurnos.Controls.Add(this.button1);
            this.gbTurnos.Controls.Add(this.tbDatosTurnos);
            this.gbTurnos.Controls.Add(this.label2);
            this.gbTurnos.Controls.Add(this.label1);
            this.gbTurnos.Controls.Add(this.dpHasta);
            this.gbTurnos.Controls.Add(this.dpDesde);
            this.gbTurnos.Controls.Add(this.plBotones);
            this.gbTurnos.Controls.Add(this.dgwTurnos);
            this.gbTurnos.Location = new System.Drawing.Point(3, 3);
            this.gbTurnos.Name = "gbTurnos";
            this.gbTurnos.Size = new System.Drawing.Size(882, 564);
            this.gbTurnos.TabIndex = 0;
            this.gbTurnos.TabStop = false;
            this.gbTurnos.Text = "Mis Turnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde:";
            // 
            // dpHasta
            // 
            this.dpHasta.CustomFormat = "MM/dd/yyyy";
            this.dpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpHasta.Location = new System.Drawing.Point(190, 21);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(84, 20);
            this.dpHasta.TabIndex = 9;
            // 
            // dpDesde
            // 
            this.dpDesde.CustomFormat = "MM/dd/yyyy";
            this.dpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDesde.Location = new System.Drawing.Point(55, 21);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(85, 20);
            this.dpDesde.TabIndex = 8;
            this.dpDesde.Value = new System.DateTime(2013, 12, 5, 0, 0, 0, 0);
            // 
            // plBotones
            // 
            this.plBotones.Controls.Add(this.btTodos);
            this.plBotones.Controls.Add(this.btPerdidos);
            this.plBotones.Controls.Add(this.btCancelados);
            this.plBotones.Controls.Add(this.btFuturos);
            this.plBotones.Controls.Add(this.btAsistidos);
            this.plBotones.Location = new System.Drawing.Point(6, 462);
            this.plBotones.Name = "plBotones";
            this.plBotones.Size = new System.Drawing.Size(408, 30);
            this.plBotones.TabIndex = 7;
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(3, 0);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 23);
            this.btTodos.TabIndex = 2;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btPerdidos
            // 
            this.btPerdidos.Location = new System.Drawing.Point(327, 0);
            this.btPerdidos.Name = "btPerdidos";
            this.btPerdidos.Size = new System.Drawing.Size(75, 23);
            this.btPerdidos.TabIndex = 6;
            this.btPerdidos.Text = "Perdidos";
            this.btPerdidos.UseVisualStyleBackColor = true;
            this.btPerdidos.Click += new System.EventHandler(this.btPerdidos_Click);
            // 
            // btCancelados
            // 
            this.btCancelados.Location = new System.Drawing.Point(84, 0);
            this.btCancelados.Name = "btCancelados";
            this.btCancelados.Size = new System.Drawing.Size(75, 23);
            this.btCancelados.TabIndex = 3;
            this.btCancelados.Text = "Cancelados";
            this.btCancelados.UseVisualStyleBackColor = true;
            this.btCancelados.Click += new System.EventHandler(this.btCancelados_Click);
            // 
            // btFuturos
            // 
            this.btFuturos.Location = new System.Drawing.Point(246, 0);
            this.btFuturos.Name = "btFuturos";
            this.btFuturos.Size = new System.Drawing.Size(75, 23);
            this.btFuturos.TabIndex = 5;
            this.btFuturos.Text = "futuros";
            this.btFuturos.UseVisualStyleBackColor = true;
            this.btFuturos.Click += new System.EventHandler(this.btFuturos_Click);
            // 
            // btAsistidos
            // 
            this.btAsistidos.Location = new System.Drawing.Point(165, 0);
            this.btAsistidos.Name = "btAsistidos";
            this.btAsistidos.Size = new System.Drawing.Size(75, 23);
            this.btAsistidos.TabIndex = 4;
            this.btAsistidos.Text = "Asistidos";
            this.btAsistidos.UseVisualStyleBackColor = true;
            this.btAsistidos.Click += new System.EventHandler(this.btAsistidos_Click);
            // 
            // dgwTurnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTurnos.Location = new System.Drawing.Point(6, 47);
            this.dgwTurnos.Name = "dgwTurnos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwTurnos.Size = new System.Drawing.Size(399, 409);
            this.dgwTurnos.TabIndex = 0;
            this.dgwTurnos.DoubleClick += new System.EventHandler(this.dgwTurnos_DoubleClick);
            // 
            // tbDatosTurnos
            // 
            this.tbDatosTurnos.Location = new System.Drawing.Point(446, 47);
            this.tbDatosTurnos.Multiline = true;
            this.tbDatosTurnos.Name = "tbDatosTurnos";
            this.tbDatosTurnos.Size = new System.Drawing.Size(393, 82);
            this.tbDatosTurnos.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 594);
            this.Controls.Add(this.paAfiliado);
            this.Name = "FormCancelarAtencion";
            this.Text = "FormCancelarAtencion";
            this.Load += new System.EventHandler(this.FormCancelarAtencion_Load);
            this.Controls.SetChildIndex(this.paAfiliado, 0);
            this.paAfiliado.ResumeLayout(false);
            this.gbTurnos.ResumeLayout(false);
            this.gbTurnos.PerformLayout();
            this.plBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paAfiliado;
        private System.Windows.Forms.GroupBox gbTurnos;
        private System.Windows.Forms.DataGridView dgwTurnos;
        private System.Windows.Forms.Button btFuturos;
        private System.Windows.Forms.Button btAsistidos;
        private System.Windows.Forms.Button btCancelados;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPerdidos;
        private System.Windows.Forms.Panel plBotones;
        private System.Windows.Forms.DateTimePicker dpHasta;
        private System.Windows.Forms.DateTimePicker dpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatosTurnos;
        private System.Windows.Forms.Button button1;
    }
}