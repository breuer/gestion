using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Clinica_Frba.Base
{
    public partial class FormBase : Form
    {

        private EActionSearch accion;
        
        public FormBase()
        {
            InitializeComponent();
        }
        public EActionSearch Accion
        {
            set { accion = value; }
            get { return accion; }
        }
        
        protected void limpiarGroupBox(GroupBox groupBox)
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
        protected void crearConsulta(GroupBox groupBox, List<SqlParameter> parametros)
        {
            foreach (Object obj in groupBox.Controls)
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
                        ComboBox cb = obj as ComboBox;
                        SqlParameter param = cb.Tag as SqlParameter;
                        if (((ComboBox)obj).SelectedIndex != -1)
                        {
                            param.Value = ((DataRowView)cb.SelectedItem)[param.ParameterName];
                            System.Console.WriteLine(param.Value);
                        }
                        parametros.Add(param);
                    }
                    else if (obj is CheckBox)
                    {
                        ((CheckBox)obj).Checked = false;
                    }
                    else if (obj is TextBox)
                    {
                        
                        TextBox tb = obj as TextBox;
                        SqlParameter param = tb.Tag as SqlParameter;
                        System.Console.WriteLine(tb.Text);
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
                    else if (obj is CheckedListBox)
                    {
                        // TODO: Solo lo uso para agregar las funcionalidades al rol para
                        // otros casos mejor usar otra cosa es medio complicado
                        CheckedListBox controls = obj as CheckedListBox;
                        using (StringWriter swStringWriter = new StringWriter())
                        {
                            DataTable dtFuncionalidad = new DataTable("Funcionalidad");
                            dtFuncionalidad.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
                            foreach (string funcionaliad in controls.CheckedItems)
                            {
                                DataRow row = dtFuncionalidad.NewRow();
                                row["Name"] = funcionaliad;
                                dtFuncionalidad.Rows.Add(row);
                            }
                            dtFuncionalidad.WriteXml(swStringWriter);
                            string str = swStringWriter.ToString();
                            SqlParameter parametroSql = new SqlParameter();
                            parametroSql.ParameterName = "funcionalidad";
                            parametroSql.DbType = DbType.Xml;
                            parametroSql.Direction = ParameterDirection.Input; // Input Parameter  
                            parametroSql.Value = str;
                            parametros.Add(parametroSql);  
                        }
                    }
                }
            }
        }

    }

}
