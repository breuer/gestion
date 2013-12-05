using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Model.Repository;
using System.Data.SqlClient;
using Clinica_Frba.Model;
using System.Collections;
using Clinica_Frba.Base;

namespace Clinica_Frba.Registrar_llegada
{
    public partial class FormRegistrarLLegadaConBono : Form
    {
        Repository repo;
        FormRegistrarLLegada frmPrincipal;
        int nroAfiliado;
        int nroTipoAfiliado;
        int nroTurno;
        DateTime fechaLLegada;
        int nroBonoConsulta;

        public FormRegistrarLLegadaConBono(int nroTurno, DateTime fechaLLegada)
        {
            repo = new Repository();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_turno", nroTurno));
            DataTable data = repo.listar("NN_NN.SP_GET_USER_BY_TURNO", parametros);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Error en carga de usuario");
                return;
            }
        
            InitializeComponent();
            this.nroAfiliado = Convert.ToInt32(data.Rows[0]["nroAfiliado"]);
            this.nroTipoAfiliado = Convert.ToInt32(data.Rows[0]["nroTipoAfiliado"]);
            this.nroTurno = nroTurno;
            this.fechaLLegada = fechaLLegada;
        }

        private void FormRegistrarLLegadaConBono_Load(object sender, EventArgs e)
        {
            repo = new Repository();
            btRegistrarLLegada.Enabled = false;
        }

        private void btChequeoBonoConsulta_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBonoConsulta.Text)));
            DataTable data = repo.listar("NN_NN.SP_GET_BONO_CONSULTA_BY_NRO", parametros);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningún bono consulta con ese número");
                return;
            }

            parametros.Clear();
            parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBonoConsulta.Text)));
            data = repo.listar("NN_NN.SP_CHEQUEAR_USO_BONO_CONSULTA", parametros);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Bono consulta usado");
                return;
            }
            parametros.Clear();
            parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBonoConsulta.Text)));
            parametros.Add(new SqlParameter("nro_usuario", nroAfiliado));
            data = repo.listar("NN_NN.SP_CHEQUEAR_PERTENENCIA_BONO_CONSULTA", parametros);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Bono consulta no pertenece al grupo familiar del usuario");
                return;
            }
            
            MessageBox.Show("Bono cargado con éxito");
            nroBonoConsulta = int.Parse(tbNroBonoConsulta.Text);
            btRegistrarLLegada.Enabled = true;
            

        }

        private void btRegistrarLLegada_Click(object sender, EventArgs e)
        {    
            //REGISTRAR LLEGADA
            List<SqlParameter> parametros = new List<SqlParameter>();            
            parametros.Add(new SqlParameter("nro_turno", nroTurno));
            parametros.Add(new SqlParameter("fecha", fechaLLegada));
            DataTable data = repo.listar("NN_NN.REGISTRAR_LLEGADA_A_TURNO", parametros);

            //GENERAR CONSULTA
            StringBuilder st = new StringBuilder();
            SqlParameter salid = new SqlParameter("return", SqlDbType.Text);
            parametros.Clear();
            parametros.Add(new SqlParameter("nro_turno", nroTurno));
            parametros.Add(new SqlParameter("nro_bono_consulta", nroBonoConsulta));
            salid.Direction = ParameterDirection.ReturnValue;
            parametros.Add(salid);
            List<SqlParameter> rta = repo.callProcedure("NN_NN.SP_GENERAR_CONSULTA", parametros);
            foreach (SqlParameter s in rta)
            {
                st.Append(s.Value);
            }
            int nroConsulta = int.Parse(st.ToString());
            if (nroConsulta > 0)
            {
                MessageBox.Show("Consulta creada con éxito nro: " + st.ToString());
                this.Close();
            }           
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
