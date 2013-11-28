using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Clinica_Frba.Model;
using Clinica_Frba.Abm_de_Rol;

namespace Clinica_Frba.Base
{
    public partial class FormSearch : FormBase
    {
        private String spName;
        private Boolean ejecutar;

        protected Boolean filtroEnable = true;

        List<SqlParameter> sqlParameterLst = new List<SqlParameter>();

        public FormSearch()
        {
            InitializeComponent();
            if (ejecutar)
            {
                this.Shown += new EventHandler(FormSearch_Shown);
            }
        }

        public FormSearch(String text, String titulo)
        {
            InitializeComponent();
            this.Text = text;
        }

        public String SpName
        {
            set { spName = value; }
            get { return spName; }
        }
        public Boolean Ejecutar
        {
            set { ejecutar = value; }
            get { return ejecutar; }
        }
        

        public Boolean FiltroEnable
        {
            set { filtroEnable = value; }
            get { return filtroEnable; }
        }

        protected virtual void btBuscar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter> ();
            this.crearConsulta(this.gbFiltro, parametros);
            this.search(parametros);
            this.fill();
        }

        protected virtual void btLimpiar_Click(object sender, EventArgs e)
        {
            //this.dgvLista.Rows.Clear();
            this.limpiarGroupBox(gbFiltro);
        }
        protected virtual void fill()
        {
        }
        protected virtual void search(List<SqlParameter> parametros)
        {
        }

       

        protected virtual void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            
        }
        
        protected virtual void settingFiltroInicial()
        {

        }
        protected virtual void settingFiltroFinal()
        {
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            if (Accion == EActionSearch.SELECCION)
            {
                settingFiltroInicial();
            }
           
        }
        protected void FormSearch_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (Ejecutar)
            {
                btBuscar_Click(sender, e);
            }
        }

   
    }
}
