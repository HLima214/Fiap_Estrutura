using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap_Estrutura_Model
{
    public  class Pessoa
    {
        public string cpf { get; set; }

        public string nome { get; set; }

        public DateOnly dtNascimento { get; set; }

        public string endereco { get; set; }
    }
}
