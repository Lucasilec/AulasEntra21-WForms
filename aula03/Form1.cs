using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        StringBuilder builder = new StringBuilder();
        public Form1()
        {
            InitializeComponent();               
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string nomeProduto = txtProduto.Text;
            double valorProduto = double.Parse(TxtValorProduto.Text);
            Produto p = new Produto(nomeProduto, valorProduto);
            produtos.Add(p);
            txtProduto.Clear();
            TxtValorProduto.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in produtos)
            {
                builder.AppendLine($"Produto: {item.NomeProduto}, Valor: {item.ValorProduto}");
            }
            MessageBox.Show(builder.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Produto
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }

        public Produto(string nomeProduto, double valorProduto)
        {
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
        }
    }
}
