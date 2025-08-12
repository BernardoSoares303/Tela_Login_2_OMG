using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Login_2_OMG
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro telacadastro = new Tela_Cadastro(this);
            this.Hide();
            telacadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Login telaLogin = new Tela_Login();
            this.Hide();
            telaLogin.Show();
        }
    }
}
