namespace Clinica_Frba.Base
{
    partial class FormAlta
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
            this.components = new System.ComponentModel.Container();
            this.btAccion = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btAccion
            // 
            this.btAccion.Location = new System.Drawing.Point(425, 433);
            this.btAccion.Name = "btAccion";
            this.btAccion.Size = new System.Drawing.Size(75, 23);
            this.btAccion.TabIndex = 1;
            this.btAccion.Text = "Guardar";
            this.btAccion.UseVisualStyleBackColor = true;
            this.btAccion.Click += new System.EventHandler(this.btAccion_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(344, 434);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(12, 434);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // gbControl
            // 
            this.gbControl.Location = new System.Drawing.Point(12, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(488, 415);
            this.gbControl.TabIndex = 4;
            this.gbControl.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 469);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btAccion);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        public System.Windows.Forms.GroupBox gbControl;
        public System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.Button btAccion;
        protected System.Windows.Forms.ErrorProvider errorProvider;
    }
}