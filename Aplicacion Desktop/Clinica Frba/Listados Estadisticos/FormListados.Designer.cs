﻿namespace Clinica_Frba.Listados_Estadisticos
{
    partial class FormListados
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
            this.gbSelector = new System.Windows.Forms.GroupBox();
            this.lvListado = new System.Windows.Forms.ListView();
            this.btGenerar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lA = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.cbReportes = new System.Windows.Forms.ComboBox();
            this.gbSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelector
            // 
            this.gbSelector.Controls.Add(this.lvListado);
            this.gbSelector.Controls.Add(this.btGenerar);
            this.gbSelector.Controls.Add(this.lbTitulo);
            this.gbSelector.Controls.Add(this.cbPeriodo);
            this.gbSelector.Controls.Add(this.label3);
            this.gbSelector.Controls.Add(this.cbYear);
            this.gbSelector.Controls.Add(this.lA);
            this.gbSelector.Controls.Add(this.lTipo);
            this.gbSelector.Controls.Add(this.cbReportes);
            this.gbSelector.Location = new System.Drawing.Point(12, 12);
            this.gbSelector.Name = "gbSelector";
            this.gbSelector.Size = new System.Drawing.Size(795, 538);
            this.gbSelector.TabIndex = 0;
            this.gbSelector.TabStop = false;
            this.gbSelector.Text = "Opciones";
            // 
            // lvListado
            // 
            this.lvListado.Location = new System.Drawing.Point(18, 153);
            this.lvListado.Name = "lvListado";
            this.lvListado.Size = new System.Drawing.Size(748, 379);
            this.lvListado.TabIndex = 2;
            this.lvListado.UseCompatibleStateImageBehavior = false;
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(414, 28);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(157, 23);
            this.btGenerar.TabIndex = 15;
            this.btGenerar.Text = "Listar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 16);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(0, 13);
            this.lbTitulo.TabIndex = 13;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(135, 102);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(256, 21);
            this.cbPeriodo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "EL SEMESTRE";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(137, 69);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(254, 21);
            this.cbYear.TabIndex = 10;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(15, 69);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(116, 13);
            this.lA.TabIndex = 9;
            this.lA.Text = "SELECCIONE EL AÑO";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(15, 31);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(99, 13);
            this.lTipo.TabIndex = 8;
            this.lTipo.Text = "TIPO DE LISTADO";
            // 
            // cbReportes
            // 
            this.cbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportes.FormattingEnabled = true;
            this.cbReportes.Location = new System.Drawing.Point(135, 28);
            this.cbReportes.Name = "cbReportes";
            this.cbReportes.Size = new System.Drawing.Size(256, 21);
            this.cbReportes.TabIndex = 7;
            // 
            // FormListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 599);
            this.Controls.Add(this.gbSelector);
            this.Name = "FormListados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormListados_Load);
            this.Controls.SetChildIndex(this.gbSelector, 0);
            this.gbSelector.ResumeLayout(false);
            this.gbSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelector;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.ComboBox cbReportes;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.ListView lvListado;
    }
}