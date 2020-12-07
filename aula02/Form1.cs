using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class Form1 : Form
    {
        public void Gerar()
        {
            

        }  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();

            string login = "Admin";
            string senha = "Admin";
            Cliente c = new Cliente(login, senha);
            clientes.Add(c);
            login = "Clebinho123";
            senha = "Joeslei";
            Cliente c1 = new Cliente(login, senha);
            clientes.Add(c1);
            login = "Jonas";
            senha = "Brothers";
            Cliente c2 = new Cliente(login, senha);
            clientes.Add(c2);

            foreach (var item in clientes)
            {
                if (item.Login == txtLogin.Text)
                {
                    MessageBox.Show("Login Efetuado");
                    break;
                }
                else
                {
                    MessageBox.Show("Login Falhou");
                    break;
                }
            }
        }
    }
    public class Cliente
    {        
        public string Login { get; set; }
        public string Senha { get; set; }

        public Cliente(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}
