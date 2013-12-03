namespace Clinica_Frba.Registrar_llegada
{
    partial class FormRegistrarLLegadaConBono
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
            this.tbNroBonoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChequeoBonoConsulta = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRegistrarLLegada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNroBonoConsulta
            // 
            this.tbNroBonoConsulta.Location = new System.Drawing.Point(185, 46);
            this.tbNroBonoConsulta.Name = "tbNroBonoConsulta";
            this.tbNroBonoConsulta.Size = new System.Drawing.Size(100, 20);
            this.tbNroBonoConsulta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar bono consulta";
            // 
            // btChequeoBonoConsulta
            // 
            this.btChequeoBonoConsulta.Location = new System.Drawing.Point(327, 49);
            this.btChequeoBonoConsulta.Name = "btChequeoBonoConsulta";
            this.btChequeoBonoConsulta.Size = new System.Drawing.Size(75, 23);
            this.btChequeoBonoConsulta.TabIndex = 2;
            this.btChequeoBonoConsulta.Text = "Cargar";
            this.btChequeoBonoConsulta.UseVisualStyleBackColor = true;
            this.btChequeoBonoConsulta.Click += new System.EventHandler(this.btChequeoBonoConsulta_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(269, 147);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRegistrarLLegada
            // 
            this.btRegistrarLLegada.Location = new System.Drawing.Point(101, 147);
            this.btRegistrarLLegada.Name = "btRegistrarLLegada";
            this.btRegistrarLLegada.Size = new System.Drawing.Size(103, 23);
            this.btRegistrarLLegada.TabIndex = 4;
            this.btRegistrarLLegada.Text = "Registrar";
            this.btRegistrarLLegada.UseVisualStyleBackColor = true;
            this.btRegistrarLLegada.Click += new System.EventHandler(this.btRegistrarLLegada_Click);
            // 
            // FormRegistrarLLegadaConBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 219);
            this.Controls.Add(this.btRegistrarLLegada);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChequeoBonoConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNroBonoConsulta);
            this.Name = "FormRegistrarLLegadaConBono";
            this.Text = "FormRegistrarLLegadaConBono";
            this.Load += new System.EventHandler(this.FormRegistrarLLegadaConBono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNroBonoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChequeoBonoConsulta;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRegistrarLLegada;
    }
}