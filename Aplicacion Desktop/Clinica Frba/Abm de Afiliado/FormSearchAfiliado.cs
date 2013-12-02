using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Base;
using Clinica_Frba.Model;
using Clinica_Frba.Interface;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class FormSearchAfiliado : FormSearch
    {
        public FormSearchAfiliado()
        {
            InitializeComponent();
        }

     
        private void FillCombo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("discriminador");
            dt.Columns.Add("codigo");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    DataRow row = dt.NewRow();
                    row["discriminador"] = i.ToString() + j.ToString();
                    row["codigo"] = Convert.ToInt32(row["discriminador"]);
                    dt.Rows.Add(row);
                }
            }
            cbDiscriminador.DataSource = dt;
        }

        private void FormSearchAfiliado_Load(object sender, EventArgs e)
        {
            // Inicializo los filtros agregandole sus respectivos nombre de paramtro
            // que utilizaran en el StoreProcedure
            
            tbNombre.Tag = new Tag("Nombre", "nombre", SqlDbType.Text);

            tbApellido.Tag = new Tag("Apellido", "apellido", SqlDbType.Text);

            cbPlan.DataSource = PlanMedico.getRepository.getPlanes();
            cbPlan.DisplayMember = "descripcion";
            cbPlan.Tag = new Tag("Plan", "plan", "codigo", SqlDbType.Int);

            cbTipo.DataSource = Afiliado.getRepository.getTipoDocumento();
            cbTipo.DisplayMember = "tipo";
            cbTipo.Tag = new Tag("tipo", "tipo", "tipoDocumento", SqlDbType.Int);

            tbDocumento.Tag = new Tag("Documento", "documento", SqlDbType.Int);

            tbNumero.Tag = new Tag("Numero", "numero", SqlDbType.Int);
            cbDiscriminador.DisplayMember = "discriminador";


            FillCombo();
            cbDiscriminador.SelectedIndex = -1;
            cbDiscriminador.Tag = new Tag("discriminador", "discriminador", "codigo", SqlDbType.Int);
            

            
        }


        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            
            DataTable data = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_afiliado]",
                parametros
            );
            dgvLista.DataSource = data;
        }

        protected override void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            Afiliado afiliado = new Afiliado();
            afiliado.NroAfiliado = int.Parse(getValueDataGrit(dgvLista, "numero"));
            afiliado.NroDiscriminador = int.Parse(getValueDataGrit(dgvLista, "discriminador"));
            afiliado.Nombre = getValueDataGrit(dgvLista, "nombre");
            afiliado.Apellido = getValueDataGrit(dgvLista, "apellido");
            

            if (Accion == EActionSearch.SELECCION)
            {
                IFInvocanteAfiliado iDestino = this.Owner as IFInvocanteAfiliado;
                if (iDestino != null)
                {
                    iDestino.seleccionarAfiliado(afiliado);
                    this.Close();
                }
            }
            else
            {
                //Para la modificacion
            }
        }
    }
}
