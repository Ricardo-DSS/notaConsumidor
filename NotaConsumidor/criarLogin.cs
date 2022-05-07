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
    public partial class criarLogin : Form
    {
        MySqlConnection conexao;

        public string dados;
        public string comando;
        public long CPF;

        public criarLogin()
        {
            InitializeComponent();

            //conexão com o banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=NotaConsumidor;Uid=root;password=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão
        }//fim do construtor


        //NOVA ENTRADA
        private void verificarCadastroExistente()
        {
            try
            {
                string verficarCadastro = "SELECT * FROM login WHERE(CPF ='" + CPF + "')";
                MySqlCommand comando = new MySqlCommand(verficarCadastro, conexao);
                MySqlDataReader ler = comando.ExecuteReader();

                if (ler.HasRows)
                {
                    MessageBox.Show("Usuário já cadastrado no sistema! Cadastre um usuário válido");
                }
                else
                {
                    CadastroLogin();
                }

                ler.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado! \n\n" + e);
            }//fim do try/catch
        }

        private void CadastroLogin()
        {
            try
            {
                dados = "('" + CPF + "','" + txtbNome.Text + "','" + txtbSenha.Text + "')";

                comando = "INSERT INTO login(CPF, nome, senha) values" + dados;

                MySqlCommand sql = new MySqlCommand(comando, conexao);
                comando = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Cadastro de usuário realizado!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!" + e);
            }//fim do try catch
        }//fim do método cadastroLogin


        //NOVA ENTRADA
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (mtbCPF.Text == "" || txtbNome.Text == "" || txtbSenha.Text == "")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!");
            }
            else
            {
                this.mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; //Exclui a máscara antes de enviar ao banco
                CPF = Convert.ToInt64(this.mtbCPF.Text);
                verificarCadastroExistente();
                mtbCPF.Clear();
            }//fim da validação de campovazio           
        }//fim do botão cadastrar usuário

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaLogin mostrar = new telaLogin();
            mostrar.Show();
        }
    }
}
