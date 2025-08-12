namespace Tela_Login_2_OMG
{
    partial class Tela_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fazer_login = new System.Windows.Forms.Button();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fazer_login
            // 
            this.fazer_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fazer_login.Location = new System.Drawing.Point(401, 341);
            this.fazer_login.Name = "fazer_login";
            this.fazer_login.Size = new System.Drawing.Size(243, 123);
            this.fazer_login.TabIndex = 5;
            this.fazer_login.Text = "Logar";
            this.fazer_login.UseVisualStyleBackColor = true;
            this.fazer_login.Click += new System.EventHandler(this.fazer_login_Click);
            // 
            // text_senha
            // 
            this.text_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.text_senha.Location = new System.Drawing.Point(242, 204);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(580, 84);
            this.text_senha.TabIndex = 4;
            this.text_senha.Text = "Senha:";
            this.text_senha.TextChanged += new System.EventHandler(this.text_senha_TextChanged);
            // 
            // text_usuario
            // 
            this.text_usuario.BackColor = System.Drawing.Color.White;
            this.text_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.text_usuario.Location = new System.Drawing.Point(242, 79);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(580, 84);
            this.text_usuario.TabIndex = 3;
            this.text_usuario.Text = "Usuario:";
            this.text_usuario.TextChanged += new System.EventHandler(this.text_usuario_TextChanged);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(166)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1065, 543);
            this.Controls.Add(this.fazer_login);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_usuario);
            this.Name = "Tela_Login";
            this.Text = "Tela_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fazer_login;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_usuario;
    }
}