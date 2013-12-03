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
            //lvTurnos.CheckBoxes = true;
            lvTurnos.MultiSelect = false;
        }

        private void tbNroAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillListView(DataTable data) 
        {
            if (data.Rows.Count == 0)
            {
                return;
            }
            else
            {
                lvTurnos.BeginUpdate();
                string subItem;
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item1 = new ListViewItem();
                    foreach (DataColumn column in data.Columns)
                    {
                        subItem = Convert.ToString(row[column]);
                        item1.SubItems.Add(subItem);
                    }
                    lvTurnos.Items.Add(item1);
                }
                lvTurnos.EndUpdate();
            }
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
                //T.fecha fecha,
                //T.numero nroTurno, 
                //A.numero nroAfiliado, 
                //A.numero_tipo_afiliado,
                //A.apellido apellidoAfiliado,
                //A.nombre nombreAfiliado
                lvTurnos.Columns.Add("check");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("nro afiliado");
                lvTurnos.Columns.Add("tipo afiliado");
                lvTurnos.Columns.Add("apellidos");
                lvTurnos.Columns.Add("nombres");
                fillListView(data);

            }
            if (tbNroProfesional.Text == "" && tbNroAfiliado.Text != "" && tbNroTipoAfiliado.Text != "")
            {
                parametros.Add(new SqlParameter("fecha", dtpCalendar.Value));
                parametros.Add(new SqlParameter("nro_afiliado", int.Parse(tbNroAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_tipo_afiliado", int.Parse(tbNroTipoAfiliado.Text)));
                data = repo.listar("NN_NN.SP_LISTA_TURNOS_AFILIADO", parametros);
           		//T.fecha fecha,
		        //T.numero nroTurno, 
		        //P.apellido apellidoProfesional,
		        //P.nombre nombreProfesional	
                lvTurnos.Columns.Add("check");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("apellidos profesional");
                lvTurnos.Columns.Add("nombres profesional");
                fillListView(data);
            }
            if (tbNroProfesional.Text != "" && tbNroAfiliado.Text != "" && tbNroTipoAfiliado.Text != "")
            {
                parametros.Add(new SqlParameter("fecha", dtpCalendar.Value));
                parametros.Add(new SqlParameter("nro_afiliado", int.Parse(tbNroAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_tipo_afiliado", int.Parse(tbNroTipoAfiliado.Text)));
                parametros.Add(new SqlParameter("nro_profesional", int.Parse(tbNroProfesional.Text)));
                data = repo.listar("NN_NN.SP_LISTA_TURNOS_AFILIADO_PROFESIONAL", parametros);                
                //T.fecha fecha,
                //T.numero nroTurno, 
                //A.numero nroAfiliado, 
                //A.numero_tipo_afiliado,
                //A.apellido apellidoAfiliado,
                //A.nombre nombreAfiliado
                lvTurnos.Columns.Add("check");
                lvTurnos.Columns.Add("fecha");
                lvTurnos.Columns.Add("nro turno");
                lvTurnos.Columns.Add("nro afiliado");
                lvTurnos.Columns.Add("tipo afiliado");
                lvTurnos.Columns.Add("apellidos afiliado");
                lvTurnos.Columns.Add("nombres afiliado");
                fillListView(data);
            }
        }

        private void btRegistrarLLegada_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvTurnos.SelectedItems[0];
            int nroTurnoSeleccionado = int.Parse(item.SubItems[2].Text);
            //MessageBox.Show(item.SubItems[0].Text + ":" + item.SubItems[1].Text + ":"
             //   + item.SubItems["nro turno"].Text + ":" + item.SubItems[3].Text);
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
                //nroAfiliado, int nroTurno, DateTime fechaLLegada
                FormRegistrarLLegadaConBono frm = 
                    new FormRegistrarLLegadaConBono(int.Parse(tbNroAfiliado.Text), 
                        nroTurnoSeleccionado, GetFechaConfig());
                frm.Show();
            }

        }        
    }
}
