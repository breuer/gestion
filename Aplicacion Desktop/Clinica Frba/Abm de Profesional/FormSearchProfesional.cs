﻿using System;
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

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class FormSearchProfesional : FormSearch
    {
        private List<TipoEspecialidadMedica> tipos;
        private List<EspecialidaMedica> especialidades;

        public List<TipoEspecialidadMedica> Tipos
        {
            get { return tipos; }
            set { tipos = value; }
        }

        public List<EspecialidaMedica> Especialidades
        {
            get { return especialidades; }
            set { especialidades = value; }
        }

        public FormSearchProfesional()
        {
            InitializeComponent();
        }

        private void FormSearchProfesional_Load(object sender, EventArgs e)
        {
            tipos = EspecialidaMedica.getRepository.getTipoList();
            especialidades = EspecialidaMedica.getRepository.getEspecialidadList();
            //tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);
            //cbFuncionalidad.Tag = new Tag("funcionalidad", "funcionalidad", SqlDbType.Text);
            actualizarCombos();

            tbApellido.Tag = new Tag("apellido", "apellido", SqlDbType.Text);
            tbNombre.Tag = new Tag("nombre", "nombre", SqlDbType.Text);
            tbMatricula.Tag = new Tag("matricula", "matricula", SqlDbType.Int);
        }

        private void actualizarCombos()
        {
            cbTipoEspecialidad.DataSource = Tipos;
            cbTipoEspecialidad.DisplayMember = "descripcion";
            cbTipoEspecialidad.SelectedIndex = -1;
            

            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "descripcion";
            cbEspecialidad.SelectedIndex = -1;
        }

      

        private void cbTipoEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TipoEspecialidadMedica tipo = (TipoEspecialidadMedica)cbTipoEspecialidad.SelectedItem;
            IEnumerable<EspecialidaMedica> es = from c in Especialidades
                                                     where c.Tipo.Codigo == tipo.Codigo
                                                     select c;
            cbEspecialidad.DataSource = es.ToList<EspecialidaMedica>();
        }
        private void cbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EspecialidaMedica es = (EspecialidaMedica)cbEspecialidad.SelectedItem;
            IEnumerable<TipoEspecialidadMedica> ls = from c in Tipos
                                                     where c.Codigo == es.Tipo.Codigo
                                                     select c;
            cbTipoEspecialidad.DataSource = ls.ToList<TipoEspecialidadMedica>();
        }

        private void btLimpiarCombo_Click(object sender, EventArgs e)
        {
            actualizarCombos();
        }


        protected override void search(List<System.Data.SqlClient.SqlParameter> parametros)
        {
            DataTable data = PlanMedico.getRepository.listar(
                "[NN_NN].[sp_listar_profesional]",
                parametros
            );
            dgvLista.DataSource = data;
        }

        protected override void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            Profesional profesional = new Profesional();
            profesional.Numero = int.Parse(getValueDataGrit(dgvLista, "numero"));
            profesional.Nombre = getValueDataGrit(dgvLista, "nombre");
            profesional.Apellido = getValueDataGrit(dgvLista, "apellido");
            profesional.Matricula = Decimal.Parse((getValueDataGrit(dgvLista, "matricula") == "") ? "0" : getValueDataGrit(dgvLista, "matricula"));

            if (Accion == EActionSearch.SELECCION)
            {
                IFInvocanteProfesional iDestino = this.Owner as IFInvocanteProfesional;
                if (iDestino != null)
                {
                    iDestino.seleccionarProfesional(profesional);
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
