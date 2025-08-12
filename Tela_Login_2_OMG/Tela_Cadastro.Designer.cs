namespace Tela_Login_2_OMG
{
    partial class Tela_Cadastro
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
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.fazer_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_usuario
            // 
            this.text_usuario.BackColor = System.Drawing.Color.White;
            this.text_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.text_usuario.Location = new System.Drawing.Point(231, 111);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(580, 84);
            this.text_usuario.TabIndex = 0;
            this.text_usuario.Text = "Usuario:";
            this.text_usuario.TextChanged += new System.EventHandler(this.text_usuario_TextChanged);
            // 
            // text_senha
            // 
            this.text_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.text_senha.Location = new System.Drawing.Point(231, 236);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(580, 84);
            this.text_senha.TabIndex = 1;
            this.text_senha.Text = "Senha:";
            this.text_senha.TextChanged += new System.EventHandler(this.text_senha_TextChanged);
            // 
            // fazer_cadastro
            // 
            this.fazer_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fazer_cadastro.Location = new System.Drawing.Point(390, 373);
            this.fazer_cadastro.Name = "fazer_cadastro";
            this.fazer_cadastro.Size = new System.Drawing.Size(243, 123);
            this.fazer_cadastro.TabIndex = 2;
            this.fazer_cadastro.Text = "Cadastrar";
            this.fazer_cadastro.UseVisualStyleBackColor = true;
            this.fazer_cadastro.Click += new System.EventHandler(this.fazer_cadastro_Click);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(166)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1065, 543);
            this.Controls.Add(this.fazer_cadastro);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_usuario);
            this.Name = "Tela_Cadastro";
            this.Text = "Tela_Cadastro";
            this.Load += new System.EventHandler(this.Tela_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Button fazer_cadastro;
    }
}