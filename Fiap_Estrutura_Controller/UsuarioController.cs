using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap_Estrutura_Repository;

namespace Fiap_Estrutura_Controller
{
    public class UsuarioController
    {
        public bool validarUsuario (string usuario, string senha)
        {
            UsuarioRepository repositorio = new UsuarioRepository();
            return validarUsuario (usuario, senha);
        }
    }
}
