﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.Base
{
    public partial class FormAlta : FormBase
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        protected StringBuilder stError = new StringBuilder();
       

        protected virtual void btLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarGroupBox(this.gbControl);
            this.loadControls();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.settingFrm();
            this.loadControls();
            this.setControlsTag();
        }

        protected virtual void settingFrm()
        {
        }
        protected virtual void loadControls()
        {
        }
        protected virtual void setControlsTag()
        {
        }
        protected virtual void ejecutarConsulta(List<SqlParameter> parametros)
        {
        }
        protected virtual String ValidarControls()
        {
            return String.Empty;
        }
        
        protected virtual void btAccion_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            String mensaje = this.ValidarControls();

            if (mensaje != String.Empty)
            {
                MessageBox.Show(mensaje);
                return;
            }
            try{
                switch (Accion){
                    case EActionSearch.ALTA:
                        List<SqlParameter> parametros = new List<SqlParameter>();
                        this.crearConsulta(this.gbControl, parametros);
                        this.ejecutarConsulta(parametros);

                        break;
                    case EActionSearch.SELECCION:
                        parametros = new List<SqlParameter>();
                        this.crearConsulta(this.gbControl, parametros);
                        this.ejecutarConsulta(parametros);
                        break;
                    case EActionSearch.MODIFICACION:
                        parametros = new List<SqlParameter>();
                        this.crearConsulta(this.gbControl, parametros);
                        this.ejecutarConsulta(parametros);
                        break;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
