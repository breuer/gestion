namespace Clinica_Frba.Base
{
    partial class FormBase
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
            this.ssTop = new System.Windows.Forms.StatusStrip();
            this.ssLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssTop
            // 
            this.ssTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ssTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabel1,
            this.ssLabel2,
            this.ssLabel3,
            this.ssLabel4});
            this.ssTop.Location = new System.Drawing.Point(0, 0);
            this.ssTop.Name = "ssTop";
            this.ssTop.Size = new System.Drawing.Size(930, 22);
            this.ssTop.TabIndex = 0;
            // 
            // ssLabel1
            // 
            this.ssLabel1.AutoSize = false;
            this.ssLabel1.Name = "ssLabel1";
            this.ssLabel1.Size = new System.Drawing.Size(109, 17);
            this.ssLabel1.Text = "toolStripStatusLabel1";
            // 
            // ssLabel2
            // 
            this.ssLabel2.AutoSize = false;
            this.ssLabel2.Name = "ssLabel2";
            this.ssLabel2.Size = new System.Drawing.Size(109, 17);
            this.ssLabel2.Text = "toolStripStatusLabel1";
            // 
            // ssLabel3
            // 
            this.ssLabel3.AutoSize = false;
            this.ssLabel3.Name = "ssLabel3";
            this.ssLabel3.Size = new System.Drawing.Size(109, 17);
            this.ssLabel3.Text = "toolStripStatusLabel1";
            // 
            // ssLabel4
            // 
            this.ssLabel4.AutoSize = false;
            this.ssLabel4.IsLink = true;
            this.ssLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ssLabel4.Name = "ssLabel4";
            this.ssLabel4.Size = new System.Drawing.Size(109, 17);
            this.ssLabel4.Text = "toolStripStatusLabel4";
            this.ssLabel4.Click += new System.EventHandler(this.ssLabel4_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 592);
            this.Controls.Add(this.ssTop);
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ssTop.ResumeLayout(false);
            this.ssTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssTop;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssLabel4;
    }
}