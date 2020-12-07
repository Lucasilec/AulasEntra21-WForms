using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05
{
    public partial class Form1 : Form
    {
        List<Funcionario> func = new List<Funcionario>();
        StringBuilder builder = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            double salario = double.Parse(txtSalario.Text);
            Funcionario f = new Funcionario(nome, cpf, salario);
            func.Add(f);
            txtCPF.Clear();
            txtNome.Clear();
            txtSalario.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in func)
            {
                builder.AppendLine($"Nome: {item.Nome}, CPF: {item.CPF}, Salario: {item.Salario.ToString("C2", CultureInfo.CurrentCulture)}");
            }
            MessageBox.Show(builder.ToString());
            builder = new StringBuilder();
        }

        private void btnMostarUmPorVez_Click(object sender, EventArgs e)
        {
            foreach (var item in func)
            {
                builder.AppendLine($"Nome: {item.Nome}, CPF: {item.CPF}, Salario: {item.Salario.ToString("C2", CultureInfo.CurrentCulture)}");
                MessageBox.Show(builder.ToString());
                Thread.Sleep(300);
                builder = new StringBuilder();
            }          
            
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            foreach (var item in func)
            {
                if (item.Salario < 2000)
                {
                    item.Salario = 2000;
                }
            }
        }
    }
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cPF, double salario)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
        }
    }
}
