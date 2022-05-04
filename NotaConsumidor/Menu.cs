using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaConsumidor
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaCadastrar mostrar = new telaCadastrar();
            mostrar.Show();
        }//fim do método mudar de tela

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaConsultar mostrar = new telaConsultar();
            mostrar.Show();
        }
    }//fim da classe
}//fim do projeto
