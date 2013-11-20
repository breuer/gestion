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
       
        
    
        
    }
}
