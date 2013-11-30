using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Clinica_Frba.Model
{
    class BonoFarmacia
    {
        int numero;
        List<Medicamento> medicamentos = new List<Medicamento>();

        public int Numero { set { numero = value; } get { return numero; } }
        public void addMedicamento(Medicamento medicamento) {
            medicamentos.Add(medicamento);
        }
        public bool notFill() {
            return medicamentos.Count <= 4; //5 elements
        }
    }
}
