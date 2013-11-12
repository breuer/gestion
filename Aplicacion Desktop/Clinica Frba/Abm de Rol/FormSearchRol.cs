using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;
using System.Data.SqlClient;
using Clinica_Frba.Model;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class FormSearchRol : FormSearch
    {
        public FormSearchRol()
        {
            InitializeComponent();
        }

        private void FormSearchRol_Load(object sender, EventArgs e)
        {
            cbFuncionalidad.DataSource = Rol.getRepository.getFuncionalidades();
            cbFuncionalidad.DisplayMember = "funcionalidad";
            cbFuncionalidad.SelectedIndex = -1;
            tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);
            cbFuncionalidad.Tag = new Tag("funcionalidad", "funcionalidad", SqlDbType.Text);
        }
        protected override void fill()
        {
            MessageBox.Show("HOLLLL");
        }
        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            DataTable dt = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_rol_funcionalidad]",
                parametros
            );
            IEnumerable<IGrouping<string, DataRow>> query = from rol in dt.AsEnumerable()
                                                           group rol by rol["ROL"].ToString() into selected
                                                           select selected;

            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("id");
            dtSource.Columns.Add("nombre");
            dtSource.Columns.Add("funcionalidad");
            dtSource.Columns.Add("habilitado");

            foreach (IGrouping<string, DataRow> item in query)
            {
                DataRow row = dtSource.NewRow();
                row["id"] = item.Key;
                StringBuilder st = new StringBuilder();
                foreach (DataRow d in item.ToList<DataRow>())
                {
                    row["id"] = d[0].ToString();
                    row["nombre"] = d[1].ToString();
                    st.Append(d[2].ToString());
                    st.Append(" ; ");
                    row["habilitado"] = d[3].ToString();
                }
                row["funcionalidad"] = st.ToString();
                dtSource.Rows.Add(row);
            }
            dgvLista.DataSource = dtSource;
        }

        protected override void dgvLista_DoubleClick(object sender, EventArgs e)
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
