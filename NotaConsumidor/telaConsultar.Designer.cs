
namespace NotaConsumidor
{
    partial class telaConsultar
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
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtbCNPJ = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConexao = new System.Windows.Forms.Label();
            this.lsvConsultaDados = new System.Windows.Forms.ListView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.lblOpcaoDeletar = new System.Windows.Forms.Label();
            this.txtbDeletar = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblVerFoto = new System.Windows.Forms.Label();
            this.txtbVerFoto = new System.Windows.Forms.TextBox();
            this.btnVerNota = new System.Windows.Forms.Button();
            this.pictureNota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Location = new System.Drawing.Point(73, 18);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(51, 13);
            this.lblConsultar.TabIndex = 0;
            this.lblConsultar.Text = "Consultar";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(73, 60);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(113, 57);
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(281, 20);
            this.txtbCNPJ.TabIndex = 2;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(457, 60);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mês";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(490, 57);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(46, 21);
            this.cmbMes.TabIndex = 4;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(575, 60);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situação";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbSituacao.Location = new System.Drawing.Point(630, 57);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(793, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(224, 34);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Location = new System.Drawing.Point(1030, 9);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(49, 13);
            this.lblConexao.TabIndex = 8;
            this.lblConexao.Text = "Conexão";
            // 
            // lsvConsultaDados
            // 
            this.lsvConsultaDados.HideSelection = false;
            this.lsvConsultaDados.Location = new System.Drawing.Point(76, 150);
            this.lsvConsultaDados.Name = "lsvConsultaDados";
            this.lsvConsultaDados.Size = new System.Drawing.Size(1029, 188);
            this.lsvConsultaDados.TabIndex = 9;
            this.lsvConsultaDados.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 773);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(76, 353);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(279, 44);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar esta consulta";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(685, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Valor Total da Nota:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Location = new System.Drawing.Point(793, 113);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbTotal.TabIndex = 15;
            // 
            // lblOpcaoDeletar
            // 
            this.lblOpcaoDeletar.AutoSize = true;
            this.lblOpcaoDeletar.Location = new System.Drawing.Point(709, 356);
            this.lblOpcaoDeletar.Name = "lblOpcaoDeletar";
            this.lblOpcaoDeletar.Size = new System.Drawing.Size(209, 13);
            this.lblOpcaoDeletar.TabIndex = 16;
            this.lblOpcaoDeletar.Text = "Insira o código da linha que deseja deletar:";
            // 
            // txtbDeletar
            // 
            this.txtbDeletar.Location = new System.Drawing.Point(924, 353);
            this.txtbDeletar.Name = "txtbDeletar";
            this.txtbDeletar.Size = new System.Drawing.Size(100, 20);
            this.txtbDeletar.TabIndex = 17;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(1030, 353);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblVerFoto
            // 
            this.lblVerFoto.AutoSize = true;
            this.lblVerFoto.Location = new System.Drawing.Point(161, 549);
            this.lblVerFoto.Name = "lblVerFoto";
            this.lblVerFoto.Size = new System.Drawing.Size(194, 13);
            this.lblVerFoto.TabIndex = 19;
            this.lblVerFoto.Text = "Insira o código da linha para ver a nota:";
            // 
            // txtbVerFoto
            // 
            this.txtbVerFoto.Location = new System.Drawing.Point(362, 549);
            this.txtbVerFoto.Name = "txtbVerFoto";
            this.txtbVerFoto.Size = new System.Drawing.Size(100, 20);
            this.txtbVerFoto.TabIndex = 20;
            // 
            // btnVerNota
            // 
            this.btnVerNota.Location = new System.Drawing.Point(256, 590);
            this.btnVerNota.Name = "btnVerNota";
            this.btnVerNota.Size = new System.Drawing.Size(118, 44);
            this.btnVerNota.TabIndex = 21;
            this.btnVerNota.Text = "Ver nota";
            this.btnVerNota.UseVisualStyleBackColor = true;
            this.btnVerNota.Click += new System.EventHandler(this.btnVerNota_Click);
            // 
            // pictureNota
            // 
            this.pictureNota.Location = new System.Drawing.Point(630, 401);
            this.pictureNota.Name = "pictureNota";
            this.pictureNota.Size = new System.Drawing.Size(401, 379);
            this.pictureNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNota.TabIndex = 22;
            this.pictureNota.TabStop = false;
            // 
            // telaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 808);
            this.Controls.Add(this.pictureNota);
            this.Controls.Add(this.btnVerNota);
            this.Controls.Add(this.txtbVerFoto);
            this.Controls.Add(this.lblVerFoto);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtbDeletar);
            this.Controls.Add(this.lblOpcaoDeletar);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lsvConsultaDados);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblConsultar);
            this.Name = "telaConsultar";
            this.Text = "telaConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtbCNPJ;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.ListView lsvConsultaDados;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label lblOpcaoDeletar;
        private System.Windows.Forms.TextBox txtbDeletar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblVerFoto;
        private System.Windows.Forms.TextBox txtbVerFoto;
        private System.Windows.Forms.Button btnVerNota;
        private System.Windows.Forms.PictureBox pictureNota;
    }
}