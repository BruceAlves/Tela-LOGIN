using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_Login.Conexão
{
    public interface IUsuario
    {
        bool VerificarLogin(string email, string senha);
    }
}
