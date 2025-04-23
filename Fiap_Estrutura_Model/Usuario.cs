using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap_Estrutura_Model
{
    internal class Usuario
    {
        public int id { get; set; }

        public string NomeUsuario { get; set; }

        public string NomeCompleto { get; set; }

        public string email { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
