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
            tbNombre.Tag = new SqlParameter("nombre", SqlDbType.Text);
            cbFuncionalidad.Tag = new SqlParameter("funcionalidad", SqlDbType.Text);
           

        }
        protected override void fill()
        {
            MessageBox.Show("HOLLLL");
        }
        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            dgvLista.DataSource = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_rol_funcionalidad]",
                parametros
            );
        }
    }
}
