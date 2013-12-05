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
    public partial class FormRegistrarLLegada : FormBase
    {
        Repository repo;
        int tipoBusqueda;

        public FormRegistrarLLegada()
        {
            InitializeComponent();
        }

        private void FormRegistrarLLegada_Load(object sender, EventArgs e)
        {
            repo = new Repository();
            dtpCalendar.Value = GetFechaConfig();
            lvTurnos.View = View.Details;
            lvTurnos.GridLines = true;
            lvTurnos.FullRowSelect = true;
            lvTurnos.MultiSelect = false;
        }

        private void tbNroAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            DataTable data;
            lvTurnos.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (tbNroProfesional.Text != "" && tbNroAfiliado.Text == "" && tbNroTipoAfiliado.Text == "")
            {
                parametros.Add(new SqlParameter("fecha", dtpCalendar.Value));
                parametros.Add(new SqlParameter("nro_profesional", int.Parse(tbNroProfesional.Text)));
                data = repo.listar("NN_NN.SP_LISTA_TURNOS_PROFESIONAL", parametros);
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("nro afiliado");
                lvTurnos.Columns.Add("tipo afiliado");
                lvTurnos.Columns.Add("apellidos afiliado");
                lvTurnos.Columns.Add("nombres afiliado");
                lvTurnos.BeginUpdate();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(row["nroTurno"]);
                    item.SubItems.Add(Convert.ToString(row["fecha"]));
                    item.SubItems.Add(Convert.ToString(row["nroAfiliado"]));
                    item.SubItems.Add(Convert.ToString(row["nroTipoAfiliado"]));
                    item.SubItems.Add(Convert.ToString(row["apellidoAfiliado"]));
                    item.SubItems.Add(Convert.ToString(row["nombreAfiliado"]));
                    lvTurnos.Items.Add(item);
                }
                lvTurnos.EndUpdate();
            }
            if (tbNroProfesional.Text == "" && tbNroAfiliado.Text != "" && tbNroTipoAfiliado.Text != "")
            {
                parametros.Add(new SqlParameter("fecha", dtpCalendar.Value));
                parametros.Add(new SqlParameter("nro_afiliado", int.Parse(tbNroAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_tipo_afiliado", int.Parse(tbNroTipoAfiliado.Text)));
                data = repo.listar("NN_NN.SP_LISTA_TURNOS_AFILIADO", parametros);
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("apellidos profesional");
                lvTurnos.Columns.Add("nombres profesional");
                lvTurnos.BeginUpdate();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(row["nroTurno"]);
                    item.SubItems.Add(Convert.ToString(row["fecha"]));
                    item.SubItems.Add(Convert.ToString(row["apellidoProfesional"]));
                    item.SubItems.Add(Convert.ToString(row["nombreProfesional"]));
                    lvTurnos.Items.Add(item);
                }
                lvTurnos.EndUpdate();
            }
            if (tbNroProfesional.Text != "" && tbNroAfiliado.Text != "" && tbNroTipoAfiliado.Text != "")
            {
                parametros.Add(new SqlParameter("fecha", dtpCalendar.Value));
                parametros.Add(new SqlParameter("nro_afiliado", int.Parse(tbNroAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_tipo_afiliado", int.Parse(tbNroTipoAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_profesional", int.Parse(tbNroProfesional.Text)));
                data = repo.listar("NN_NN.SP_LISTA_TURNOS_AFILIADO_PROFESIONAL", parametros);                
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("nro afiliado");
                lvTurnos.Columns.Add("tipo afiliado");
                lvTurnos.Columns.Add("apellidos afiliado");
                lvTurnos.Columns.Add("nombres afiliado");
                lvTurnos.BeginUpdate();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(row["nroTurno"]);
                    item.SubItems.Add(Convert.ToString(row["fecha"]));
                    item.SubItems.Add(Convert.ToString(row["nroAfiliado"]));
                    item.SubItems.Add(Convert.ToString(row["nroTipoAfiliado"]));
                    item.SubItems.Add(Convert.ToString(row["apellidoAfiliado"]));   
                    item.SubItems.Add(Convert.ToString(row["nombreAfiliado"]));
                    lvTurnos.Items.Add(item);
                }
                lvTurnos.EndUpdate();
            }
        }

        private void btRegistrarLLegada_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvTurnos.SelectedItems[0];
            int nroTurnoSeleccionado = int.Parse(item.Text);
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_turno", nroTurnoSeleccionado));
            parametros.Add(new SqlParameter("fecha", GetFechaConfig()));
            DataTable data = repo.listar("NN_NN.CHEQUEAR_HORARIO", parametros);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Horario excedido");
            }
            else
            {
                FormRegistrarLLegadaConBono frm = 
                    new FormRegistrarLLegadaConBono(nroTurnoSeleccionado, GetFechaConfig());
                frm.Show();
            }
        }        
    }
}
