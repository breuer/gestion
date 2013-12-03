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
using System.Globalization;
using Clinica_Frba.Model;

namespace Clinica_Frba.Base
{
    public partial class FormBase : Form
    {

        private Profesional profesionalCurrent;

        private Afiliado afiliadoCurrent;

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
        public Profesional ProfesionalCurrent
        {
            get { return this.profesionalCurrent; }
            set { this.profesionalCurrent = value; }
        }
        public Afiliado AfiliadoCurrent
        {
            get { return this.afiliadoCurrent; }
            set { this.afiliadoCurrent = value; }
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
            parametros.Clear();
            foreach (Object oobj in groupBox.Controls)
            {
                // Ignoro los controles que son visuales (label tooltip)
                Control obj = oobj as Control;
                if (!(obj is Label) && obj.Visible)
                {
                    if (obj is GroupBox)
                    {
                        GroupBox gb = obj as GroupBox;
                        if (gb.Name.Equals("gbSexo"))
                        {
                            RadioButton rbFemenino = gb.Controls["rbFemenino"] as RadioButton;
                            Tag tag = gb.Tag as Tag;
                            if (rbFemenino.Checked)
                            {
                                tag.Value = 'F';
                            }
                            else
                            {
                                tag.Value = 'M';
                            }
                            parametros.Add(tag.SQLParemeter);
                        }
                        else if (gb.Name.Equals("gbTipoEspecialidad"))
                        {
                            ComboBox cb = gb.Controls["cbTipoEspecialidad"] as ComboBox;
                            if (cb.SelectedIndex > -1)
                            {
                                TipoEspecialidadMedica tipo = cb.SelectedItem as TipoEspecialidadMedica;
                                SqlParameter sql = new SqlParameter("cod_tipo", tipo.Codigo);
                                parametros.Add(sql);
                            }
                            cb = gb.Controls["cbEspecialidad"] as ComboBox;
                            if (cb.SelectedIndex > -1)
                            {
                                EspecialidaMedica espe = cb.SelectedItem as EspecialidaMedica;
                                SqlParameter sql = new SqlParameter("cod_especialidad", espe.Codigo);
                                parametros.Add(sql);
                            }
                        }
                        else if (gb.Name.Equals("gbTurno"))
                        {
                            int rol = 1;
                            parametros.Add(
                                new SqlParameter(
                                    "rol", 
                                    rol
                                )
                            );
                            
                            if (ProfesionalCurrent != null)
                            {
                                parametros.Add(
                                    new SqlParameter(
                                        "idProfesional",
                                        ProfesionalCurrent.Numero
                                    )
                                );
                            }
                            if (AfiliadoCurrent != null)
                            {
                                parametros.Add(
                                    new SqlParameter(
                                        "idAfiliado",
                                        AfiliadoCurrent.NroAfiliado
                                    )
                                );
                                parametros.Add(
                                    new SqlParameter(
                                        "tipoAfiliado",
                                        AfiliadoCurrent.NroDiscriminador
                                    )
                                );
                            }
                        }
                        //  limpiarGroupBox((GroupBox)obj);

                    }
                    else if (obj is ComboBox)
                    {
                        ComboBox cb = obj as ComboBox;
                        Tag tag = cb.Tag as Tag;
                        if (cb.SelectedIndex != -1)
                        {
                           tag.Value = ((DataRowView)cb.SelectedItem)[tag.ParamColumn];
                        }
                        parametros.Add(tag.SQLParemeter);
                    }
                    else if (obj is CheckBox)
                    {
                        CheckBox ck = obj as CheckBox;
                        Tag tag = ck.Tag as Tag;
                        tag.Value = ck.Checked;
                        parametros.Add(tag.SQLParemeter);
                    }
                    else if (obj is TextBox)
                    {
                        TextBox tb = obj as TextBox;
                        Tag tag = tb.Tag as Tag;
                        if (tb.Text != null && !"".Equals(tb.Text))
                        {
                            switch (tag.SQLDbType)
                            {
                                case SqlDbType.Text:
                                    tag.Value = tb.Text;
                                    break;
                                case SqlDbType.Binary:
                                    MessageBox.Show("DATE TIME");
                                    break;
                                case SqlDbType.Int:
                                    tag.Value = Int32.Parse(tb.Text);
                                    break;
                                case SqlDbType.DateTime:
                                    MessageBox.Show("DATE TIME");
                                    break;
                            }
                        }
                        else
                        {
                            tag.Value = null;
                        }
                        parametros.Add(tag.SQLParemeter);
                    } else if (obj is DateTimePicker)
                    {
                        DateTimePicker dt = obj as DateTimePicker;
                        Tag tag = dt.Tag as Tag;
                        tag.Value = dt.Value;
                        parametros.Add(tag.SQLParemeter);
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

        protected void keyPresssDigit(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        protected DateTime GetFullFechaConfig()
        {
            DateTime configTime = DateTime.ParseExact(
                Properties.Settings.Default.fechaConfig,
                Properties.Settings.Default.fechaFormat,
                CultureInfo.InvariantCulture
            );
            return configTime;
        }
        /// <summary>
        /// Retorna solo el dia mes año de la fecha de configuracion
        /// </summary>
        /// <returns>DateTime</returns>
        protected DateTime GetFechaConfig()
        {
            DateTime configTime = DateTime.ParseExact(
                Properties.Settings.Default.fechaConfig,
                Properties.Settings.Default.fechaFormat,
                CultureInfo.InvariantCulture
            );
            try
            {
                DateTime fecha = new DateTime(
                    configTime.Year,
                    configTime.Month,
                    configTime.Day,
                    0,
                    0,
                    0
                );
                return fecha;
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(
                   "La fecha proporcionada por la configuracion no es valida. Si decea continuar?",
                   Application.ProductName,
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Error
               );
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                DateTime now = new DateTime();
                return new DateTime(
                    now.Year,
                    now.Month,
                    now.Day,
                    0,
                    0,
                    0
                );
            }
        }
        /// <summary>
        /// Compara 2 fechas sin tener en cuenta la horas y las fehas
        /// </summary>
        /// <returns></returns>
        protected int compararFechas(DateTime date1, DateTime date2)
        {
            DateTime fecha1 = new DateTime(
                date1.Year,
                date1.Month,
                date1.Day,
                0,
                0,
                0
            );
            DateTime fecha2 = new DateTime(
                date2.Year,
                date2.Month,
                date2.Day,
                0,
                0,
                0
             );
             return DateTime.Compare(fecha1, fecha2);
        }

        protected DateTime getFechaSinTiempo(DateTime datetime)
        {
            DateTime fecha1 = new DateTime(
               datetime.Year,
               datetime.Month,
               datetime.Day,
               0,
               0,
               0
            );
            return fecha1;
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

        protected Object getObjectValueDataGrit(DataGridView dgvLista, string nameColumn)
        {
            bool bEncontro = false;
            for (int i = 0; i < dgvLista.Columns.Count; i++)
            {
                bEncontro = dgvLista.Columns[dgvLista.CurrentRow.Cells[i].ColumnIndex].HeaderText.ToUpper().Equals(nameColumn.ToUpper());
                if (bEncontro)
                    return dgvLista.CurrentRow.Cells[i].Value;
            }
            return "";
        }

        protected void FormBase_Load(object sender, EventArgs e)
        {
            switch (DataSession.idRol)
            {
                case 2:
                    this.AfiliadoCurrent = DataSession.afiliadoSession;
                    break;
                case 3:
                    this.ProfesionalCurrent = DataSession.profesionalSession;
                    break;
            }
        }

    }


}
