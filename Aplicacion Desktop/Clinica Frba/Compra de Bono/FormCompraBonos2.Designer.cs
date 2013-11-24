namespace Clinica_Frba.Compra_de_Bono
{
    partial class FormCompraBonos2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inNroAfiliado = new System.Windows.Forms.TextBox();
            this.inCantBonosConsulta = new System.Windows.Forms.TextBox();
            this.inNroTipoAfiliado = new System.Windows.Forms.TextBox();
            this.inputCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inCantBonosFarmacia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro afiliado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro tipo afiliado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cant bonos consulta";
            // 
            // inNroAfiliado
            // 
            this.inNroAfiliado.Location = new System.Drawing.Point(160, 29);
            this.inNroAfiliado.Name = "inNroAfiliado";
            this.inNroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.inNroAfiliado.TabIndex = 3;
            // 
            // inCantBonosConsulta
            // 
            this.inCantBonosConsulta.Location = new System.Drawing.Point(161, 124);
            this.inCantBonosConsulta.Name = "inCantBonosConsulta";
            this.inCantBonosConsulta.Size = new System.Drawing.Size(100, 20);
            this.inCantBonosConsulta.TabIndex = 4;
            // 
            // inNroTipoAfiliado
            // 
            this.inNroTipoAfiliado.Location = new System.Drawing.Point(160, 80);
            this.inNroTipoAfiliado.Name = "inNroTipoAfiliado";
            this.inNroTipoAfiliado.Size = new System.Drawing.Size(100, 20);
            this.inNroTipoAfiliado.TabIndex = 5;
            // 
            // inputCompra
            // 
            this.inputCompra.Location = new System.Drawing.Point(239, 249);
            this.inputCompra.Name = "inputCompra";
            this.inputCompra.Size = new System.Drawing.Size(75, 23);
            this.inputCompra.TabIndex = 6;
            this.inputCompra.Text = "Comprar";
            this.inputCompra.UseVisualStyleBackColor = true;
            this.inputCompra.Click += new System.EventHandler(this.inputCompra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cant bonos farmacia";
            // 
            // inCantBonosFarmacia
            // 
            this.inCantBonosFarmacia.Location = new System.Drawing.Point(160, 164);
            this.inCantBonosFarmacia.Name = "inCantBonosFarmacia";
            this.inCantBonosFarmacia.Size = new System.Drawing.Size(100, 20);
            this.inCantBonosFarmacia.TabIndex = 8;
            // 
            // FormCompraBonos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 284);
            this.Controls.Add(this.inCantBonosFarmacia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputCompra);
            this.Controls.Add(this.inNroTipoAfiliado);
            this.Controls.Add(this.inCantBonosConsulta);
            this.Controls.Add(this.inNroAfiliado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCompraBonos2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormCompraBonos2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inNroAfiliado;
        private System.Windows.Forms.TextBox inCantBonosConsulta;
        private System.Windows.Forms.TextBox inNroTipoAfiliado;
        private System.Windows.Forms.Button inputCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inCantBonosFarmacia;
    }
}