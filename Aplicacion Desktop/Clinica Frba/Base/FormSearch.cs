using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinica_Frba.Base
{
    public partial class FormSearch : FormBase
    {
        private String spName;

        List<SqlParameter> sqlParameterLst = new List<SqlParameter>();
        
        public FormSearch()
        {
            InitializeComponent();
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

        protected virtual void btBuscar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter> ();
            this.crearConsulta(this.gbFiltro, parametros);
            this.search(parametros);
            this.fill();
        }

       

        protected virtual void btLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvLista.Rows.Clear();
            this.limpiarGroupBox(gbFiltro);
        }
        protected virtual void fill()
        {
        }
        protected virtual void search(List<SqlParameter> parametros)
        {
        }
    }
}
