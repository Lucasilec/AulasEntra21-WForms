using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01
{
    public partial class Form1 : Form
    {
        string Informacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Informacao += txtNome.Text + "\n";
            Informacao += txtIdade.Text + "\n";
            Informacao += txtCPF.Text + "\n";
            MessageBox.Show(Informacao);
        }
    }
}
