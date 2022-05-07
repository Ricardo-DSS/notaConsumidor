
namespace NotaConsumidor
{
    partial class telaCadastrar
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
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtbCNPJ = new System.Windows.Forms.TextBox();
            this.txtbFornecedor = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtbDia = new System.Windows.Forms.TextBox();
            this.txtbMes = new System.Windows.Forms.TextBox();
            this.txtbAno = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtbProduto = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtbQtd = new System.Windows.Forms.TextBox();
            this.lblPrecoUnit = new System.Windows.Forms.Label();
            this.txtbPreco = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtbValorTotalProduto = new System.Windows.Forms.TextBox();
            this.lblValorTotalNota = new System.Windows.Forms.Label();
            this.txtbValorTotalNota = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblConexao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Location = new System.Drawing.Point(355, 31);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(52, 13);
            this.lblCadastrar.TabIndex = 0;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(25, 86);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(65, 83);
            this.txtbCNPJ.MaxLength = 14;
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(217, 20);
            this.txtbCNPJ.TabIndex = 2;
            this.txtbCNPJ.TextChanged += new System.EventHandler(this.txtbCNPJ_TextChanged);
            // 
            // txtbFornecedor
            // 
            this.txtbFornecedor.Location = new System.Drawing.Point(92, 115);
            this.txtbFornecedor.MaxLength = 45;
            this.txtbFornecedor.Name = "txtbFornecedor";
            this.txtbFornecedor.Size = new System.Drawing.Size(190, 20);
            this.txtbFornecedor.TabIndex = 4;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(476, 83);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(523, 83);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(570, 83);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Ano";
            // 
            // txtbDia
            // 
            this.txtbDia.Location = new System.Drawing.Point(479, 99);
            this.txtbDia.MaxLength = 2;
            this.txtbDia.Name = "txtbDia";
            this.txtbDia.Size = new System.Drawing.Size(41, 20);
            this.txtbDia.TabIndex = 8;
            // 
            // txtbMes
            // 
            this.txtbMes.Location = new System.Drawing.Point(526, 99);
            this.txtbMes.MaxLength = 2;
            this.txtbMes.Name = "txtbMes";
            this.txtbMes.Size = new System.Drawing.Size(41, 20);
            this.txtbMes.TabIndex = 9;
            // 
            // txtbAno
            // 
            this.txtbAno.Location = new System.Drawing.Point(573, 99);
            this.txtbAno.MaxLength = 4;
            this.txtbAno.Name = "txtbAno";
            this.txtbAno.Size = new System.Drawing.Size(41, 20);
            this.txtbAno.TabIndex = 10;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(28, 194);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto";
            // 
            // txtbProduto
            // 
            this.txtbProduto.Location = new System.Drawing.Point(79, 194);
            this.txtbProduto.MaxLength = 45;
            this.txtbProduto.Name = "txtbProduto";
            this.txtbProduto.Size = new System.Drawing.Size(471, 20);
            this.txtbProduto.TabIndex = 12;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(570, 197);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(24, 13);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "Qtd";
            // 
            // txtbQtd
            // 
            this.txtbQtd.Location = new System.Drawing.Point(600, 194);
            this.txtbQtd.MaxLength = 4;
            this.txtbQtd.Name = "txtbQtd";
            this.txtbQtd.Size = new System.Drawing.Size(100, 20);
            this.txtbQtd.TabIndex = 14;
            // 
            // lblPrecoUnit
            // 
            this.lblPrecoUnit.AutoSize = true;
            this.lblPrecoUnit.Location = new System.Drawing.Point(28, 239);
            this.lblPrecoUnit.Name = "lblPrecoUnit";
            this.lblPrecoUnit.Size = new System.Drawing.Size(74, 13);
            this.lblPrecoUnit.TabIndex = 15;
            this.lblPrecoUnit.Text = "Preço Unitário";
            // 
            // txtbPreco
            // 
            this.txtbPreco.Location = new System.Drawing.Point(112, 239);
            this.txtbPreco.Name = "txtbPreco";
            this.txtbPreco.Size = new System.Drawing.Size(233, 20);
            this.txtbPreco.TabIndex = 16;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(405, 245);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(98, 13);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total Produto";
            // 
            // txtbValorTotalProduto
            // 
            this.txtbValorTotalProduto.Location = new System.Drawing.Point(510, 242);
            this.txtbValorTotalProduto.Name = "txtbValorTotalProduto";
            this.txtbValorTotalProduto.Size = new System.Drawing.Size(190, 20);
            this.txtbValorTotalProduto.TabIndex = 18;
            // 
            // lblValorTotalNota
            // 
            this.lblValorTotalNota.AutoSize = true;
            this.lblValorTotalNota.Location = new System.Drawing.Point(28, 296);
            this.lblValorTotalNota.Name = "lblValorTotalNota";
            this.lblValorTotalNota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValorTotalNota.Size = new System.Drawing.Size(84, 13);
            this.lblValorTotalNota.TabIndex = 19;
            this.lblValorTotalNota.Text = "Valor Total Nota";
            // 
            // txtbValorTotalNota
            // 
            this.txtbValorTotalNota.Location = new System.Drawing.Point(118, 293);
            this.txtbValorTotalNota.Name = "txtbValorTotalNota";
            this.txtbValorTotalNota.Size = new System.Drawing.Size(226, 20);
            this.txtbValorTotalNota.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(409, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbStatus.Location = new System.Drawing.Point(455, 293);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(139, 21);
            this.cmbStatus.TabIndex = 22;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(492, 358);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(25, 118);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 25;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Location = new System.Drawing.Point(476, 31);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(49, 13);
            this.lblConexao.TabIndex = 26;
            this.lblConexao.Text = "Conexão";
            this.lblConexao.Click += new System.EventHandler(this.lblconexao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(166, 358);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // telaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtbValorTotalNota);
            this.Controls.Add(this.lblValorTotalNota);
            this.Controls.Add(this.txtbValorTotalProduto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtbPreco);
            this.Controls.Add(this.lblPrecoUnit);
            this.Controls.Add(this.txtbQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtbAno);
            this.Controls.Add(this.txtbMes);
            this.Controls.Add(this.txtbDia);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtbFornecedor);
            this.Controls.Add(this.txtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblCadastrar);
            this.Name = "telaCadastrar";
            this.Text = "telaCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtbCNPJ;
        private System.Windows.Forms.TextBox txtbFornecedor;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtbDia;
        private System.Windows.Forms.TextBox txtbMes;
        private System.Windows.Forms.TextBox txtbAno;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtbProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtbQtd;
        private System.Windows.Forms.Label lblPrecoUnit;
        private System.Windows.Forms.TextBox txtbPreco;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtbValorTotalProduto;
        private System.Windows.Forms.Label lblValorTotalNota;
        private System.Windows.Forms.TextBox txtbValorTotalNota;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Button btnVoltar;
    }
}