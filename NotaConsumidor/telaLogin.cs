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
    public partial class telaLogin : Form
    {
        MySqlConnection conexao;

        private string userName;

        public long usuario;
        public string senha;
        public string nome;
        
        //NOVA ENTRADA
        public string ModificarUserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }//fim do método ModificarUserName

        public telaLogin()
        {
            InitializeComponent();
        }//fim do construtor

        private void verificarAcesso()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=NotaConsumidor;Uid=root;Password=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão

            try
            {
                string verficarUsuario = "SELECT * FROM login WHERE(CPF ='" + usuario + "') and (senha='" + senha + "')";
                MySqlCommand comando = new MySqlCommand(verficarUsuario, conexao);
                MySqlDataReader ler = comando.ExecuteReader();

                //NOVA ENTRADA

                if (ler.HasRows)
                {
                    this.Visible = false;
                    Menu mostrar = new Menu();
                    mostrar.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }

                ler.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado! \n\n" + e);
            }//fim do try/catch
        }//fim do método de verificação

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtbUsuario.Text == "" || txtbSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para acessar o sistema!");
            }
            else
            {
                usuario = Convert.ToInt64(txtbUsuario.Text);
                senha = txtbSenha.Text;
                verificarAcesso();
            }//fim da verificação de campos vazios
        }//fim do método mudar de tela

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            criarLogin mostrar = new criarLogin();
            mostrar.Show();
        }//fim do botão criar usuario
    }//fim da classe
}//fim do projeto
