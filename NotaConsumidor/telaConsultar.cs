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
    public partial class telaConsultar : Form
    {
        //teste
        MySqlConnection conexao;

        public string total;
        public string atualizacao;
        public int validacao = 0;
        //comentário teste
        //comentário teste
        public string CNPJ;
        public string mes;
        public byte situacao;

        public telaConsultar()
        {
            InitializeComponent();

            //permite o usuario mudar o tamanho da coluna
            lsvConsultaDados.AllowColumnReorder = true;
            //cada item vai ser exibido em uma linha separada
            lsvConsultaDados.View = View.Details;
            //clicar em um item seleciona toda a linha
            lsvConsultaDados.FullRowSelect = true;
            //desenha linhas de grade
            lsvConsultaDados.GridLines = true;

            //adiciona dentro do listBox as colunas com nomes, tamanhos e alinhamentos
            lsvConsultaDados.Columns.Add("codigo", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("CNPJ", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("fornecedor", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("dia", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("mes", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("ano", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("nomeProduto", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("precoUnitario", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("quantidade", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("valorTotalProduto", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("valorTotalNota", 100, HorizontalAlignment.Left);
            //lsvConsultaDados.Columns.Add("situacao", 80, HorizontalAlignment.Left);

            conexao = new MySqlConnection("server=localhost;DataBase=NotaConsumidor;Uid=root;password=;");
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

        public void Consultar()
        {
            try
            {
                string query = "select * from notaFiscal where(CNPJ = " + CNPJ + ") and (mes = " + mes + ") and (situacao = " +
                                situacao + ")";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                MySqlDataReader ler = comando.ExecuteReader();

                lsvConsultaDados.Items.Clear();

                while (ler.Read())
                {
                    string[] linha =
                    {
                        ler.GetString(0),
                        ler.GetString(1),
                        ler.GetString(2),
                        ler.GetString(3),
                        ler.GetString(4),
                        ler.GetString(5),
                        ler.GetString(6),
                        ler.GetString(7),
                        ler.GetString(8),
                        ler.GetString(9),
                        ler.GetString(10),
                        //ler.GetString(11),
                    };

                    var linha_view = new ListViewItem(linha);

                    lsvConsultaDados.Items.Add(linha_view);
                }//fim do while          

                ler.Close();

            }//fim da consulta ao banco
            catch(Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
            }

        }//fim do método Preencher

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            validacao = 1;//variavel que habilita o funcionamento do botao "atualizar consulta"

            CNPJ = txtbCNPJ.Text;
            mes = Convert.ToString(cmbMes.SelectedItem);

            if (Convert.ToString(cmbSituacao.SelectedItem) == "Pendente")
            {
                situacao = 1;
            }
            else
            {
                situacao = 0;
            }

            Consultar();
            valorTotal();

        }//fim do botão Consultar 

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do botão mostrar

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (validacao == 1)
            {

                MessageBox.Show("Você tem certeza que deseja realizar essa operação?", "Aviso", MessageBoxButtons.YesNo);

                var msg = MessageBox.Show("Você tem certeza que deseja realizar essa operação?", "Aviso", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    CNPJ = txtbCNPJ.Text;
                    mes = Convert.ToString(cmbMes.SelectedItem);

                    if ((Convert.ToString(cmbSituacao.SelectedItem) == "Pendente"))
                    {
                        atualizacao = "update notaFiscal set situacao = '0' where (CNPJ = " + CNPJ + ") and (mes =" + mes +
                                        ") and (situacao =" + situacao + ")";
                        MySqlCommand atual = new MySqlCommand(atualizacao, conexao);
                        atualizacao = "" + atual.ExecuteNonQuery();
                        MessageBox.Show("Nota atualizada!");
                    }//fim da atualização
                }//fim da ação de atualização em caso positivo
                if (msg == DialogResult.No)
                {
                    telaConsultar mostrar = new telaConsultar();
                    mostrar.Show();
                }//fim da ação que encerra o textbox
            }//fim da condição necessária para atualizar o dado

            validacao = 0;

        }//fim do botão atualizar

        private void valorTotal()//Joga a soma da coluna preço em um textBox
        {
            string funcao = "select SUM(valorTotalProduto) AS total FROM notafiscal where(CNPJ = " + CNPJ + ") and (mes = " + mes + ") and (situacao = " +
                                situacao + ")";

            MySqlCommand comando = new MySqlCommand(funcao,conexao);

            MySqlDataReader valorTotal = comando.ExecuteReader();

            while (valorTotal.Read())
            {
                total = Convert.ToString(valorTotal["total"]);
            }

            valorTotal.Close();

            txtbTotal.Text = total;
        }//fim do método valorTotal

        private void Deletar()//deleta da base de dados TODA uma linha de acordo com o código
        {

            string funcao = "delete from notaFiscal where codigo =" + txtbDeletar.Text + "";

            MySqlCommand comando = new MySqlCommand(funcao, conexao);

            funcao = "" + comando.ExecuteNonQuery();

            MessageBox.Show("Linha deletada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fim do método deletar linha

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar();
        }//fim do botão deletar
    }//fim da classe
}//fim do projeto
