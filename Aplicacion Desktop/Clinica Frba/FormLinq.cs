using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class FormLinq : Form
    {
        public FormLinq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder st = new StringBuilder();
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            int[] exculde = new int[3] {3,5,6};

            var numQuery =
                from num in numbers
                from ex in exculde
                where num != ex
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                st.AppendLine(num.ToString());
            }
            tbSalida.Text = st.ToString();
        }
    }
}
