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
        MySqlConnection conexao;

        public string CNPJ;
        public string mes;
        public byte situacao;

        /* public int[] codigo;
        public string[] CNPJ;
        public string[] fornecedor;
        public string[] dia;
        public string[] mes;
        public string[] ano;
        public string[] nomeProduto;
        public double[] precoUnitario;
        public int[] quantidade;
        public double[] valorTotalProduto;
        public double[] valorTotalNota;
        public bool[] situacao;
        public int i; */

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
            lsvConsultaDados.Columns.Add("situacao", 80, HorizontalAlignment.Left);

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
                        ler.GetString(11),
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


            /* codigo = new int[100];
            CNPJ = new string[100];
            fornecedor = new string[100];
            dia = new string[100];
            mes = new string[100];
            ano = new string[100];
            nomeProduto = new string[100];
            precoUnitario = new double[100];
            quantidade = new int[100];
            valorTotalProduto = new double[100];
            valorTotalNota = new double[100];
            situacao = new bool[100]; */

        }//fim do método Preencher

        private void btnConsultar_Click(object sender, EventArgs e)
        {
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
        }//fim do botão Consultar 

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do botão mostrar
    }//fim da classe
}//fim do projeto
