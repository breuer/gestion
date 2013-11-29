namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class FormSearchAfiliado
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
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDiscriminador = new System.Windows.Forms.ComboBox();
            this.pBusqueda.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.gbBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.cbDiscriminador);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.tbNumero);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.tbApellido);
            this.gbFiltro.Controls.Add(this.tbNombre);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.tbDocumento);
            this.gbFiltro.Controls.Add(this.cbTipo);
            this.gbFiltro.Controls.Add(this.label11);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.cbPlan);
            this.gbFiltro.Controls.Add(this.label10);
            this.gbFiltro.Controls.SetChildIndex(this.gbBaja, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label10, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbPlan, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label11, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbTipo, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbDocumento, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbNombre, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbApellido, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbFiltro.Controls.SetChildIndex(this.tbNumero, 0);
            this.gbFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbFiltro.Controls.SetChildIndex(this.cbDiscriminador, 0);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(72, 29);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(150, 21);
            this.cbPlan.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Plan:";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(176, 62);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(142, 20);
            this.tbDocumento.TabIndex = 31;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DNI"});
            this.cbTipo.Location = new System.Drawing.Point(72, 62);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(45, 21);
            this.cbTipo.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tipo:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(391, 59);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(246, 20);
            this.tbApellido.TabIndex = 35;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(391, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(246, 20);
            this.tbNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(73, 98);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(133, 20);
            this.tbNumero.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Discriminador:";
            // 
            // cbDiscriminador
            // 
            this.cbDiscriminador.FormattingEnabled = true;
            this.cbDiscriminador.Location = new System.Drawing.Point(300, 97);
            this.cbDiscriminador.Name = "cbDiscriminador";
            this.cbDiscriminador.Size = new System.Drawing.Size(121, 21);
            this.cbDiscriminador.TabIndex = 39;
            // 
            // FormSearchAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Name = "FormSearchAfiliado";
            this.Text = "FormSearchAfiliado";
            this.Load += new System.EventHandler(this.FormSearchAfiliado_Load);
            this.pBusqueda.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbBaja.ResumeLayout(false);
            this.gbBaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDiscriminador;
    }
}