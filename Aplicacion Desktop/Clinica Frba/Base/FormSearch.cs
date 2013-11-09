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
            //this.dgvLista.Rows.Clear();
            this.limpiarGroupBox(gbFiltro);
        }
        protected virtual void fill()
        {
        }
        protected virtual void search(List<SqlParameter> parametros)
        {
        }

        protected string getValueDataGrit(DataGridView dgvLista, string nameColumn)
        {
            bool bEncontro = false;
            for (int i = 0; i < dgvLista.Columns.Count; i++)
            {
                bEncontro = dgvLista.Columns[dgvLista.CurrentRow.Cells[i].ColumnIndex].HeaderText.ToUpper().Equals(nameColumn.ToUpper());
                if (bEncontro)
                    return dgvLista.CurrentRow.Cells[i].Value.ToString();
            }
            return "";
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLista.RowCount == 0)
            {
                return;
            }
            Rol rol = new Rol();
            rol.Id = int.Parse(getValueDataGrit(dgvLista, "id"));
            rol.Nombre = this.getValueDataGrit(dgvLista,"nombre");
            rol.Habilitado = this.getValueDataGrit(dgvLista, "habilitado").Equals("true") ? true : false;
            string[] funcionalidades = this.getValueDataGrit(dgvLista, "FUNCIONALIDAD").Split(';');
            rol.Funcionaliadades = funcionalidades.ToList<string>();
            FormAltaRol frm = new FormAltaRol();
            frm.Accion = EActionSearch.MODIFICACION;
            frm.Rol = rol;
            frm.ShowDialog(this);
        }
    }
}
