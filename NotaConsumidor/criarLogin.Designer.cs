
namespace NotaConsumidor
{
    partial class criarLogin
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
            this.lblCriarLogin = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCriarLogin
            // 
            this.lblCriarLogin.AutoSize = true;
            this.lblCriarLogin.Location = new System.Drawing.Point(360, 44);
            this.lblCriarLogin.Name = "lblCriarLogin";
            this.lblCriarLogin.Size = new System.Drawing.Size(57, 13);
            this.lblCriarLogin.TabIndex = 0;
            this.lblCriarLogin.Text = "Criar Login";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(81, 114);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(77, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "Informe o CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 164);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(84, 217);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(164, 164);
            this.txtbNome.MaxLength = 45;
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(204, 20);
            this.txtbNome.TabIndex = 7;
            // 
            // txtbSenha
            // 
            this.txtbSenha.Location = new System.Drawing.Point(164, 217);
            this.txtbSenha.MaxLength = 8;
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.Size = new System.Drawing.Size(204, 20);
            this.txtbSenha.TabIndex = 8;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(363, 298);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarUsuario.TabIndex = 9;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(165, 114);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(639, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // criarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCriarLogin);
            this.Name = "criarLogin";
            this.Text = "criarLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriarLogin;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnLogin;
    }
}