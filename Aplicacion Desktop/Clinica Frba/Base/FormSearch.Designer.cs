namespace Clinica_Frba.Base
{
    partial class FormSearch
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
            this.lbTituloMain = new System.Windows.Forms.Label();
            this.pBusqueda = new System.Windows.Forms.Panel();
            this.btVolver = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.gbBaja = new System.Windows.Forms.GroupBox();
            this.ckBaja = new System.Windows.Forms.CheckBox();
            this.pBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloMain
            // 
            this.lbTituloMain.AutoSize = true;
            this.lbTituloMain.Location = new System.Drawing.Point(2, 9);
            this.lbTituloMain.Name = "lbTituloMain";
            this.lbTituloMain.Size = new System.Drawing.Size(133, 13);
            this.lbTituloMain.TabIndex = 9;
            this.lbTituloMain.Text = "Gestor De FLotas Desktop";
            // 
            // pBusqueda
            // 
            this.pBusqueda.Controls.Add(this.btVolver);
            this.pBusqueda.Controls.Add(this.btAlta);
            this.pBusqueda.Controls.Add(this.dgvLista);
            this.pBusqueda.Controls.Add(this.btBuscar);
            this.pBusqueda.Controls.Add(this.btLimpiar);
            this.pBusqueda.Controls.Add(this.gbFiltro);
            this.pBusqueda.Location = new System.Drawing.Point(2, 35);
            this.pBusqueda.Name = "pBusqueda";
            this.pBusqueda.Size = new System.Drawing.Size(913, 476);
            this.pBusqueda.TabIndex = 11;
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(3, 450);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            // 
            // btAlta
            // 
            this.btAlta.Enabled = false;
            this.btAlta.Location = new System.Drawing.Point(828, 450);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 23);
            this.btAlta.TabIndex = 4;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(0, 171);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(903, 270);
            this.dgvLista.TabIndex = 3;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(828, 142);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(0, 142);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 1;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.gbBaja);
            this.gbFiltro.Location = new System.Drawing.Point(0, 3);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(903, 133);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtros de busqueda";
            // 
            // gbBaja
            // 
            this.gbBaja.Controls.Add(this.ckBaja);
            this.gbBaja.Location = new System.Drawing.Point(683, 19);
            this.gbBaja.Name = "gbBaja";
            this.gbBaja.Size = new System.Drawing.Size(200, 50);
            this.gbBaja.TabIndex = 4;
            this.gbBaja.TabStop = false;
            this.gbBaja.Text = "groupBox1";
            // 
            // ckBaja
            // 
            this.ckBaja.AutoSize = true;
            this.ckBaja.Location = new System.Drawing.Point(6, 19);
            this.ckBaja.Name = "ckBaja";
            this.ckBaja.Size = new System.Drawing.Size(47, 17);
            this.ckBaja.TabIndex = 0;
            this.ckBaja.Tag = "enable";
            this.ckBaja.Text = "Baja";
            this.ckBaja.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Controls.Add(this.pBusqueda);
            this.Controls.Add(this.lbTituloMain);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.pBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbBaja.ResumeLayout(false);
            this.gbBaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lbTituloMain;
        protected System.Windows.Forms.Panel pBusqueda;
        protected System.Windows.Forms.Button btVolver;
        public System.Windows.Forms.Button btAlta;
        protected System.Windows.Forms.DataGridView dgvLista;
        protected System.Windows.Forms.Button btBuscar;
        protected System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.GroupBox gbBaja;
        private System.Windows.Forms.CheckBox ckBaja;
    }
}