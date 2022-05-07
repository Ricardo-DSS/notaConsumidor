using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NotaConsumidor
{
    public partial class telaCadastrar : Form
    {
        MySqlConnection conexao;

        public string dados = "";
        public string comando = "";

        public string CNPJ = "";
        public string fornecedor = "";
        public string dia = "";
        public string mes = "";
        public string ano = "";
        public string nomeProduto = "";
        public double precoUnitario = 0;
        public int quantidade = 0;
        public double valorTotalProduto = 0;
        public double valorTotalNota = 0;
        public byte situacao;

        public telaCadastrar()
        {
            InitializeComponent();

            conexao = new MySqlConnection("server=localhost;DataBase=NotaConsumidor;Uid=root;Password=;");
            try
            {
                conexao.Open();
                lblConexao.Text = "Conexão bem sucedida!";
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão

        }//fim do construtor

        public void Inserir()
        {
            try
            {
                dados = "('','" + CNPJ + "','" + fornecedor + "','" + dia + "','" + mes + "','" + ano + "','" + nomeProduto +
                    "','" + precoUnitario + "','" + quantidade + "','" + valorTotalProduto + "','" + valorTotalNota + "','" +
                    situacao + "')";
                comando = "insert into notaFiscal(codigo, CNPJ, fornecedor, dia, mes, ano, nomeProduto, precoUnitario, quantidade, " +
                    "valorTotalProduto, valorTotalNota, situacao) values" + dados;
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                comando = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Linha(s) afetada(s)!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
            }
        }//fim do método inserir

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool ok = campoVazio();
            if (ok == true)
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CNPJ = txtbCNPJ.Text;
                fornecedor = txtbFornecedor.Text;
                dia = txtbDia.Text;
                mes = txtbMes.Text;
                ano = txtbAno.Text;
                nomeProduto = txtbProduto.Text;
                precoUnitario = Convert.ToDouble(txtbPreco.Text);
                quantidade = Convert.ToInt32(txtbQtd.Text);
                valorTotalProduto = Convert.ToDouble(txtbValorTotalProduto.Text);
                valorTotalNota = Convert.ToDouble(txtbValorTotalNota.Text);

                if (Convert.ToString(cmbStatus.SelectedItem) == "Pendente")
                {
                    situacao = 1; //coluna situacao vai receber 1 para valor que ainda será pago
                }
                else
                {
                    situacao = 0; //coluna situacao vai receber 0 para valor já pago
                }

                Inserir();
            }            
        }//fim do botão cadastrar


        private void txtbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }//fim do textbox CNPJ

        private void lblconexao_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do método voltar

        private bool campoVazio()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBoxBase)
                {
                    var txt = (TextBoxBase)item;
                    if (String.IsNullOrEmpty(txt.Text))
                        return true;
                }
            }//valida todos os textbox do forms

            return false;
        }//fim do método campoVazio
    }//fim da classe
}//fim do projeto
