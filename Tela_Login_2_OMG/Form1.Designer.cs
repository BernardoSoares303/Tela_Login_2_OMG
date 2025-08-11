namespace Tela_Login_2_OMG
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.Fazer_Cadastro = new System.Windows.Forms.Button();
            this.Fazer_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fazer_Cadastro
            // 
            this.Fazer_Cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(89)))));
            this.Fazer_Cadastro.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Fazer_Cadastro.Location = new System.Drawing.Point(359, 119);
            this.Fazer_Cadastro.Name = "Fazer_Cadastro";
            this.Fazer_Cadastro.Size = new System.Drawing.Size(351, 109);
            this.Fazer_Cadastro.TabIndex = 0;
            this.Fazer_Cadastro.Text = "Fazer Cadastro";
            this.Fazer_Cadastro.UseVisualStyleBackColor = false;
            this.Fazer_Cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fazer_Login
            // 
            this.Fazer_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(89)))));
            this.Fazer_Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fazer_Login.Location = new System.Drawing.Point(359, 282);
            this.Fazer_Login.Name = "Fazer_Login";
            this.Fazer_Login.Size = new System.Drawing.Size(351, 109);
            this.Fazer_Login.TabIndex = 1;
            this.Fazer_Login.Text = "Fazer Login";
            this.Fazer_Login.UseVisualStyleBackColor = false;
            this.Fazer_Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(166)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1065, 543);
            this.Controls.Add(this.Fazer_Login);
            this.Controls.Add(this.Fazer_Cadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fazer_Cadastro;
        private System.Windows.Forms.Button Fazer_Login;
    }
}

