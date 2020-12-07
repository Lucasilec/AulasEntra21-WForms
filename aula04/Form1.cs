using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula04
{
    public partial class Form1 : Form
    {
        List<string> nomes = new List<string>();
        StringBuilder builder = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int achouCont = 0;
            foreach (var item in nomes)
            {
                if (item == txtNome.Text)
                {
                    achouCont++;
                }
            }
            if (achouCont == 0 && nomes.Count < 5)
            {
                nomes.Add(txtNome.Text);
            }
            else if (achouCont > 0)
            {
                MessageBox.Show("Valor repetido");
            }
            else if (nomes.Capacity > 4)
            {
                btnMostrar_Click(sender, e);
            }
            txtNome.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in nomes)
            {
                builder.AppendLine($"Nome: {item}");
            }
            MessageBox.Show(builder.ToString());          
        }
    }
}
