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
    public partial class FormSearch : Form
    {
        private EActionSearch accion;
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

        public EActionSearch Accion
        {
            set { accion = value; }
            get { return accion; }
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

        private void crearConsulta(GroupBox groupBox, List<SqlParameter> parametros)
        {
            foreach (Object obj in gbFiltro.Controls)
            {
                // Ignoro los controles que son visuales (text tooltip) 
                if (!(obj is Label))
                {
                    if (obj is GroupBox)
                    {
                      //  limpiarGroupBox((GroupBox)obj);
                    }
                    else if (obj is ComboBox)
                    {
                        ((ComboBox)obj).SelectedIndex = -1;
                    }
                    else if (obj is CheckBox)
                    {
                        ((CheckBox)obj).Checked = false;
                    }
                    else if (obj is TextBox)
                    {
                        TextBox tb = obj as TextBox;
                        SqlParameter param = tb.Tag as SqlParameter;

                        if (tb.Text != null && !"".Equals(tb.Text))
                        {
                            switch (param.SqlDbType)
                            {
                                case SqlDbType.Text:
                                    param.Value = tb.Text;
                                    break;
                                case SqlDbType.Binary:
                                    MessageBox.Show("DATE TIME");
                                    break;
                                case SqlDbType.Int:
                                    param.Value = Int32.Parse(tb.Text);
                                    break;
                                case SqlDbType.DateTime:
                                    MessageBox.Show("DATE TIME");
                                    break;
                            }
                        }
                        parametros.Add(param);
                    }
                }
            }
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

        private void limpiarGroupBox(GroupBox groupBox) 
        {
            foreach (Object obj in groupBox.Controls)
            {
                if (!(obj is Label))
                {
                    if (obj is GroupBox)
                    {
                        limpiarGroupBox((GroupBox)obj);
                    }
                    else if (obj is ComboBox)
                    {
                        ((ComboBox)obj).SelectedIndex = -1;
                    }
                    else if (obj is CheckBox)
                    {
                        ((CheckBox)obj).Checked = false;
                    }
                    else if (obj is TextBox)
                    {
                        ((Control)obj).Text = "";
                    }
                }
            }
        }
    }
}
