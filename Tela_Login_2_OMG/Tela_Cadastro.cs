using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tela_Login_2_OMG
{
    public partial class Tela_Cadastro : Form
    {
        string usuario;
        string senha;
        string senhacrip;
        private Form f1;
        public Tela_Cadastro(Form f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Tela_Cadastro_Load(object sender, EventArgs e)
        {

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

        private void fazer_cadastro_Click(object sender, EventArgs e)
        {
            inserirdados(usuario, senhacrip);
            this.Close();
            f1.Show();
        }

        static string conexao = "Server=127.0.0.1;Port=3306;Database=tela_login;Uid=root;Pwd='' ;";

        static void inserirdados(string usuario, string senha)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string queryinsert = @"insert into usuarios (nome_usuario, senha_usuario) values (@nome_usuario, @senha_usuario);";
                    MySqlCommand cmd = new MySqlCommand(queryinsert, conn);

                    cmd.Parameters.AddWithValue("@nome_usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha_usuario", senha);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }
    }
}
