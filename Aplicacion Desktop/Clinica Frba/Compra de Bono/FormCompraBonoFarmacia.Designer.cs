namespace Clinica_Frba.Compra_de_Bono
{
    partial class FormCompraBonoFarmacia
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
            this.tbCantidadBonosFarmacia = new System.Windows.Forms.TextBox();
            this.btComprarBonosFarmacia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad bonos farmacia";
            // 
            // tbCantidadBonosFarmacia
            // 
            this.tbCantidadBonosFarmacia.Location = new System.Drawing.Point(172, 50);
            this.tbCantidadBonosFarmacia.Name = "tbCantidadBonosFarmacia";
            this.tbCantidadBonosFarmacia.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadBonosFarmacia.TabIndex = 1;
            // 
            // btComprarBonosFarmacia
            // 
            this.btComprarBonosFarmacia.Location = new System.Drawing.Point(172, 110);
            this.btComprarBonosFarmacia.Name = "btComprarBonosFarmacia";
            this.btComprarBonosFarmacia.Size = new System.Drawing.Size(75, 23);
            this.btComprarBonosFarmacia.TabIndex = 2;
            this.btComprarBonosFarmacia.Text = "Comprar";
            this.btComprarBonosFarmacia.UseVisualStyleBackColor = true;
            this.btComprarBonosFarmacia.Click += new System.EventHandler(this.btComprarBonosFarmacia_Click);
            // 
            // FormCompraBonoFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 262);
            this.Controls.Add(this.btComprarBonosFarmacia);
            this.Controls.Add(this.tbCantidadBonosFarmacia);
            this.Controls.Add(this.label1);
            this.Name = "FormCompraBonoFarmacia";
            this.Text = "FormCompraBonoFarmacia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidadBonosFarmacia;
        private System.Windows.Forms.Button btComprarBonosFarmacia;
    }
}