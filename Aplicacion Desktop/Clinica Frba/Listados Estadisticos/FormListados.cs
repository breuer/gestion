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
using Clinica_Frba.Model.Repository;

namespace Clinica_Frba.NewFolder9
{
    public partial class FormListados : FormBase
    {
        public FormListados()
        {
            InitializeComponent();
        }
        private Dictionary<int, delegateListados> listados = new Dictionary<int, delegateListados>();

        delegate void delegateListados(DateTime fechaF0, DateTime fechaF1);

        private void ini_mapListados()
        {
            listados.Add(0, new delegateListados(this.listaTop5CancelacionesByEspecialidades));
            listados.Add(1, new delegateListados(this.listaTop5BonosFarmacia));
            listados.Add(2, new delegateListados(this.listaTop5EspecialidadesByMedicosWithMoreBonos));
            listados.Add(3, new delegateListados(this.listaTop10AfiliadosByBonosNoCompradosPorEllos));
        }

        private void ini_comboReportes()
        {
            List<string> listaReportes = new List<string>();
            listaReportes.Add("Top  5  de  las  especialidades  que  más  se  registraron  cancelaciones,  tanto  de pacientes como de profesionales.");
            listaReportes.Add("Top 5 de la cantidad total de bonos farmacia vencidos por afiliado.");
            listaReportes.Add("Top 5 de las especialidades de médicos con más bonos de farmacia recetados.");
            listaReportes.Add("Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron.");
            cbReportes.DataSource = listaReportes;
        }

        private void ini_comboSemetre()
        {
            List<string> lista = new List<string>();
            lista.Add("Primer semestre (Enero - Junio)");
            lista.Add("Segundo trimestre (Julio - Diciembre)");
            cbPeriodo.DataSource = lista;
        }

        private void ini_comboYear()
        {
            List<int> lista = new List<int>();
            DateTime now;

            // Tomo la fecha definida en el config. Si esta fecha esta 
            // Mal definda se toma la fecha actual
            now = getFechaConfig();
            
            for (int i = 0; i < (now.Year - Properties.Settings.Default.yearF0) + 1; i++)
            {
                lista.Add(Properties.Settings.Default.yearF0 + i);
            }
            cbYear.DataSource = lista;
        }

        private void FormListados_Load(object sender, EventArgs e)
        {
            this.ini_comboReportes();
            this.ini_comboYear();
            this.ini_comboSemetre();
            this.ini_mapListados();
            this.cbPeriodo.SelectedIndex = 0;
            this.cbReportes.SelectedIndex = 0;
            this.cbYear.SelectedIndex = 0;
        }

        private void ejecutar(String sql, DateTime fechaF0, DateTime fechaF1)
        {
            List<SqlParameter> lst = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("fechaF0", SqlDbType.DateTime);
            param.Value = fechaF0;
            lst.Add(param);
            param = new SqlParameter("fechaF1", SqlDbType.DateTime);
            param.Value = fechaF1;
            lst.Add(param);

            DataTable dt = (new Repository()).listar(sql, lst);
            this.dgvLista.DataSource = dt;
        }

        // Sobreprograme un poco. Con una lista de nombres de storeProcedure puede que sea mas simple
        // Top  5  de  las  especialidades  que  más  se  registraron  cancelaciones,  tanto  de pacientes como de profesionales.
        private void listaTop5CancelacionesByEspecialidades(DateTime fechaF0, DateTime fechaF1)
        {
            lbTitulo.Text = "Top  5  de  las  especialidades  que  más  se  registraron  cancelaciones,  tanto  de pacientes como de profesionales.";
            this.ejecutar("[NN_NN].[SP_TOP_5_CANCELACIONES_BY_ESPECIALIDADES]", fechaF0, fechaF1);
        }

        //Top 5 de la cantidad total de bonos farmacia vencidos por afiliado.
        private void listaTop5BonosFarmacia(DateTime fechaF0, DateTime fechaF1)
        {
            lbTitulo.Text = "Top 5 de la cantidad total de bonos farmacia vencidos por afiliado.";
            this.ejecutar("[NN_NN].[SP_TOP_5_BONOS_FARMACIA]", fechaF0, fechaF1);
        }
        //Top 5 de las especialidades de médicos con más bonos de farmacia recetados.
        private void listaTop5EspecialidadesByMedicosWithMoreBonos(DateTime fechaF0, DateTime fechaF1)
        {
            lbTitulo.Text = "Top 5 de las especialidades de médicos con más bonos de farmacia recetados.";
            this.ejecutar("[NN_NN].[SP_TOP_5_ESPECIALIDADES_BY_MORE_BONOS]", fechaF0, fechaF1);
        }

        //Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron.
        private void listaTop10AfiliadosByBonosNoCompradosPorEllos(DateTime fechaF0, DateTime fechaF1)
        {
            lbTitulo.Text = "Top 10 de los afiliados que utilizaron bonos que ellos mismo no compraron.";
            this.ejecutar("[NN_NN].[SP_TOP_10_AFILIADOS_BONOS_COMPRADOS_POR_OTROS]", fechaF0, fechaF1);
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            int year = (int)cbYear.SelectedItem;
            int monthF0 = (cbPeriodo.SelectedIndex * 6) + 1;
            int monthF1 = (cbPeriodo.SelectedIndex * 6) + 6;
            DateTime fechaF0 = new DateTime(year, monthF0, 1);
            DateTime fechaF1 = new DateTime(year, monthF1, 1);
            fechaF1 = fechaF1.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            delegateListados delegado = listados[cbReportes.SelectedIndex];
            delegado(fechaF0, fechaF1);
        }
    }
}
