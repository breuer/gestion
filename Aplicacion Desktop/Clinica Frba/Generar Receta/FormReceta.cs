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


namespace Clinica_Frba.Generar_Receta
{
    public partial class FormReceta : FormBase
    {
        List<BonoFarmacia> bonosFarmacia;
        Repository repo;
        int nroConsulta;

        public FormReceta(int nroConsulta)
        {
            InitializeComponent();
            this.nroConsulta = nroConsulta;
        }

        

        private void FormReceta_Load(object sender, EventArgs e)
        {
           // gbAgregarMedicamento.Enabled = false;
            repo = new Repository();
            bonosFarmacia = new List<BonoFarmacia>();
        }

        private void btAddMedicamento_Click(object sender, EventArgs e)
        {
            if (bonosFarmacia.Count != 0)
            {
                if (bonosFarmacia[bonosFarmacia.Count - 1].notFill())
                {
                    Medicamento medicamento = new Medicamento();
                    medicamento.Descripcion = tbMedicamento.Text;
                    medicamento.Cantidad = int.Parse(tbCantidad.Text);
                    bonosFarmacia[bonosFarmacia.Count - 1].addMedicamento(medicamento);
                    lbListaMedicamentos.BeginUpdate();
                    lbListaMedicamentos.Items.Add(
                        "Bono nro: " + Convert.ToString(bonosFarmacia[bonosFarmacia.Count - 1].Numero) 
                        + " - " + tbMedicamento.Text);
                    tbMedicamento.Clear();
                    tbCantidad.Clear();
                }
                else
                {
                    MessageBox.Show("Debe agregar un bono farmacia");
                }
                lbListaMedicamentos.EndUpdate();
                tbMedicamento.Clear();
                tbCantidad.Clear();
            }
            else
            {
                MessageBox.Show("Debe agregar un bono farmacia");
            }
        }

        private void btCargarBonoFarmacia_Click(object sender, EventArgs e)
        {
            //string date = Convert.ToString(GetFechaConfig());
            //MessageBox.Show(date);
            if (tbNroBono.Text != "")
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBono.Text)));
                DataTable dataUsuario = repo.listar("NN_NN.SP_CHEQUEAR_EXISTENCIA_BONO_FARMACIA", parametros);
                if (dataUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("Bono farmacia no existe");
                    tbNroBono.Clear();
                    return;
                }

                parametros.Clear();
                parametros.Add(new SqlParameter("nro_usuario", DataSession.nroAfiliadoReceta));
                parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBono.Text)));
                dataUsuario = repo.listar("NN_NN.SP_CHEQUEAR_PERTENENCIA_BONO_FARMACIA", parametros);
                if (dataUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("Bono farmacia no pertenece a usuario");
                    tbNroBono.Clear();
                    return;
                }
                

                parametros.Clear();
                parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBono.Text)));
                parametros.Add(new SqlParameter("fecha", GetFechaConfig()));
                dataUsuario = repo.listar("NN_NN.SP_CHEQUEAR_VENCIMIENTO_BONO_FARMACIA", parametros);
                if (dataUsuario.Rows.Count > 0)
                {
                    MessageBox.Show("Bono farmacia vencido");
                    tbNroBono.Clear();
                    return;
                }

                parametros.Clear();
                parametros.Add(new SqlParameter("nro_bono", int.Parse(tbNroBono.Text)));
                dataUsuario = repo.listar("NN_NN.SP_CHEQUEAR_USO_BONO_FARMACIA", parametros);
                if (dataUsuario.Rows.Count > 0)
                {
                    MessageBox.Show("Bono farmacia ya usado");
                    tbNroBono.Clear();
                    return;
                }
                

                BonoFarmacia bono = new BonoFarmacia();
                bono.Numero = int.Parse(tbNroBono.Text);
                bonosFarmacia.Add(bono);
                MessageBox.Show("Bono agregado con éxito");
                tbNroBono.Clear();
            }
        }

        private void btGenerarReceta_Click(object sender, EventArgs e)
        {
            StringBuilder st = new StringBuilder();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nro_consulta", nroConsulta));
            SqlParameter salid = new SqlParameter("return", SqlDbType.Text);
            salid.Direction = ParameterDirection.ReturnValue;
            parametros.Add(salid);
            List<SqlParameter> rta = repo.callProcedure("NN_NN.SP_GENERAR_RECETA", parametros);            
            foreach (SqlParameter s in rta)
            {
                st.Append(s.Value);
            }
            int nroReceta = int.Parse(st.ToString());
            foreach (BonoFarmacia bono in bonosFarmacia)
            {
                foreach (Medicamento medicamento in bono.Medicamentos)
                {
                    parametros.Clear();
                    parametros.Add(new SqlParameter("descripcion", medicamento.Descripcion));
                    parametros.Add(new SqlParameter("nro_bono", bono.Numero));
                    parametros.Add(new SqlParameter("cantidad", medicamento.Cantidad));
                    repo.callProcedure("NN_NN.SP_ADD_MEDICAMENTO", parametros);
                }
                parametros.Clear();
                parametros.Add(new SqlParameter("nro_receta", nroReceta));
                parametros.Add(new SqlParameter("nro_bono", bono.Numero));
                repo.callProcedure("NN_NN.SP_ADD_BONO_FARMACIA_IN_RECETA", parametros);
            }
            MessageBox.Show("Receta creada con éxito");
            this.Close();
        }
       

    }
}

