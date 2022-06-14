using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login.Conexão;

namespace Tela_Login
{
    public partial class TelLogin : Form
    {
        public TelLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUsuario conexaoUsuario = new Usuario();
            bool usuarioValido = conexaoUsuario.VerificarLogin(txtEmail.Text, txtSenha.Text);

            if (usuarioValido)
            {
                MessageBox.Show("Usuario logado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                LimparCampo();
            }
            else
            {
                MessageBox.Show("Credenciais Inválidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        public void LimparCampo()
        {
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
    }


}
