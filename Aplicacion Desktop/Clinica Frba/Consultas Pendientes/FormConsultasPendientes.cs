﻿using System;
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
using Clinica_Frba.Registro_Resultado_Atencion;

namespace Clinica_Frba.Consultas_Pendientes
{
    public partial class FormConsultasPendientes : FormBase
    {
        Repository repo;

        public FormConsultasPendientes()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            dtpFechaConsultas.Value = GetFechaConfig();
            repo = new Repository();
            lvConsultasPendientes.View = View.Details;
            lvConsultasPendientes.GridLines = true;
            lvConsultasPendientes.FullRowSelect = true;
            lvConsultasPendientes.MultiSelect = false;
            //lvConsultasPendientes.Columns.Add("check");
            lvConsultasPendientes.Columns.Add("nro consulta");
            lvConsultasPendientes.Columns.Add("nro turno");
            lvConsultasPendientes.Columns.Add("nro afiliado");
            lvConsultasPendientes.Columns.Add("apellido");
            lvConsultasPendientes.Columns.Add("nombre");
        }

        private void btAtenderConsulta_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvConsultasPendientes.SelectedItems[0];
            int nroConsulta = int.Parse(item.Text);
            int nroAfiliado = int.Parse(item.SubItems[2].Text);

            
            //MessageBox.Show("consulta: " + item.SubItems[1].Text);
            FormAtencion frm = new FormAtencion(nroConsulta, nroAfiliado);
            frm.Show();
        }

        private void btCargarConsultas_Click(object sender, EventArgs e)
        {            
            List<SqlParameter> parametros = new List<SqlParameter>();
            //DataSession.profesionalSession.
            int nroProfesional = Convert.ToInt32(DataSession.profesionalSession.Numero);
            parametros.Add(new SqlParameter("nro_profesional", nroProfesional));
            parametros.Add(new SqlParameter("fecha", GetFechaConfig()));
            DataTable data = repo.listar("NN_NN.SP_CONSULTAS_PENDIENTES", parametros);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No hay consultas pendientes");
            }
            else
            {
                lvConsultasPendientes.Items.Clear();
                //lvTurnos.CheckBoxes = true;
                //C.numero nro_consulta,
		        //C.nro_turno nro_turno,
		        //A.numero nro_afiliado,
		        //A.apellido apellido_afiliado,
		        //A.nombre nombre_afiliado;
                lvConsultasPendientes.BeginUpdate();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(row["nro_consulta"]);
                    item.SubItems.Add(Convert.ToString(row["nro_turno"]));
                    item.SubItems.Add(Convert.ToString(row["nro_afiliado"]));
                    item.SubItems.Add(Convert.ToString(row["apellido_afiliado"]));
                    item.SubItems.Add(Convert.ToString(row["nombre_afiliado"]));   
                    lvConsultasPendientes.Items.Add(item);
                }
                lvConsultasPendientes.EndUpdate();
            }
        }
    }
}
