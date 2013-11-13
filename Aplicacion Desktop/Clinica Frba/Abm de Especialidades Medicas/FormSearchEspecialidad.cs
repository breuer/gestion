using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clinica_Frba.Base;
using Clinica_Frba.Model;
using Clinica_Frba.Interface;


namespace Clinica_Frba.Abm_de_Especialidades_Medicas
{
    public partial class FormSearchEspecialidad : FormSearch
    {
        private List<EspecialidaMedica> excluir;

        public List<EspecialidaMedica> Excluir
        {
            set { excluir = value; }
            get { return excluir; }
        }

        public FormSearchEspecialidad()
        {
            InitializeComponent();
        }
        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            DataTable data = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_especialidad]",
                parametros
            );
            // Como no estoy paguinado lo puedo realizar asi
            if (Excluir != null && Excluir.Count > 0)
            {
                DataTable newData = new DataTable();
                //TODO Luego ver No es muy eficiente esto 
                newData = data.Clone();
                newData.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    EspecialidaMedica es = new EspecialidaMedica();
                    es.Codigo =  Decimal.ToInt32((Decimal)row[0]);
                    if (!Excluir.Contains(es))
                    {
                        newData.ImportRow(row);
                    }
                }
                dgvLista.DataSource = newData;      
            }
            else
            {
                dgvLista.DataSource = data;
            }
            
        }
        private void FormSearchEspecialidad_Load(object sender, EventArgs e)
        {
            cbTipoEspecialidad.DataSource = EspecialidaMedica.getRepository.getTipo();
            cbTipoEspecialidad.DisplayMember = "codigo";
            cbTipoEspecialidad.SelectedIndex = -1;
            cbTipoEspecialidad.Tag = new Tag("codigoTipo", "codigoTipo", SqlDbType.Int);
            
            tbCodigo.Tag = new Tag("codigo", "codigo", SqlDbType.Int);

            tbDescripcion.Tag = new Tag("descripcion", "descripcion", SqlDbType.Text);
 
        }

        protected override void settingFiltroInicial()
        {
            
        }


        protected override void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            EspecialidaMedica especialidad = new EspecialidaMedica();
            especialidad.Codigo = int.Parse(getValueDataGrit(dgvLista, "codigo"));
            especialidad.Descripcion = getValueDataGrit(dgvLista, "descripcion");
          
            if (Accion == EActionSearch.SELECCION)
            {
                IFInvocanteEspecialidad iDestino = this.Owner as IFInvocanteEspecialidad;
                if (iDestino != null)
                {
                    iDestino.seleccionarEspecialidad(especialidad);
                    this.Close();
                }
            }
            else
            {
                // UpdateMicro frm = new UpdateMicro();
                // frm.Accion = ETipoAccion.MODIFICACION;
                // frm.Micro = dto;
                // frm.ShowDialog(this);
            }
        }
        protected override void fill()
        {
            MessageBox.Show("HOLLLL");
        }
     

    
    }
}
