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

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class FormReceta : Form
    {
        List<BonoFarmacia> bonosFarmacia = new List<BonoFarmacia>();
        public FormReceta()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {// Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(400, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form.
            this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            //listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            //listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            //for (int x = 1; x <= 50; x++)
            //{
             //   listBox1.Items.Add("Item " + x.ToString());
            //}
            // Allow the ListBox to repaint and display the new items.
            //listBox1.EndUpdate();

            // Select three items from the ListBox.
            //listBox1.SetSelected(1, true);
            //listBox1.SetSelected(3, true);
            //listBox1.SetSelected(5, true);

            // Display the second selected item in the ListBox to the console.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedItems[1].ToString());
            // Display the index of the first selected item in the ListBox.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndices[0].ToString());             

        }*/

        private void FormReceta_Load(object sender, EventArgs e)
        {
           // gbAgregarMedicamento.Enabled = false;
        }

        private void btAddMedicamento_Click(object sender, EventArgs e)
        {
            if (bonosFarmacia.Count != 0)
            {
                //BonoFarmacia bono = bonosFarmacia[bonosFarmacia.Count - 1].;
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
            if (tbNroBono.Text != "")
            {
                Repository repo = new Repository();
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
                dataUsuario = repo.listar("NN_NN.SP_CHEQUEAR_VENCIMIENTO_BONO_FARMACIA", parametros);
                if (dataUsuario.Rows.Count > 0)
                {
                    MessageBox.Show("Bono farmacia vencido");
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
    }
}
