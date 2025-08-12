using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tela_Login_2_OMG
{
    public partial class Tela_Login : Form
    {
        static string conexao = "Server=127.0.0.1;Port=3306;Database=tela_login;Uid=root;Pwd='' ;";

        string usuario;
        string senha;
        string senhacrip;

        Page1 page1 = new Page1();
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {
            usuario = text_usuario.Text;
        }

        private void text_senha_TextChanged(object sender, EventArgs e)
        {
            senha = text_senha.Text;
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] bytes =
                sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)

                    sb.Append(b.ToString("x2"));
                senhacrip = sb.ToString();
            }
        }

        private void fazer_login_Click(object sender, EventArgs e)
        {
            if (ValidarLogin(usuario, senhacrip) == 1)
            {
                this.Close();
                page1.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
            }
        }

        static int ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string querySelect = $@"select count(id_usuario) from usuarios where nome_usuario = '{usuario}' and senha_usuario = '{senha}';";

                using (MySqlCommand cmd = new MySqlCommand(querySelect, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                    return count;
                }
            }
        }
    }
}
