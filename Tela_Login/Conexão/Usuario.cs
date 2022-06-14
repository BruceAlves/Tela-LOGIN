using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Login.Conexão
{
    public class Usuario : IUsuario
    {
        public bool VerificarLogin(string email, string senha)
        {
            bool usuarioValido = false;

            string conexao = "Server=localhost;Database=telacadastro;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from cadastros where  email ='{email}' and senha = '{senha}'";

            MySqlConnection mySql = new MySqlConnection(conexao);

            DataTable dtUsuario = new DataTable();

            try
            {
                mySql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySql);
                adapter.Fill(dtUsuario);

            }
            catch (Exception )
            {
                MessageBox.Show("Erro de conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySql.Close();
            }          

            if(dtUsuario.Rows.Count > 0)
            {
                return true;
            }

            return usuarioValido;
        }

    }
}
