using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap_Estrutura_Model
{
    public class Funcionario : Pessoa
    {
        public int cdMatricula {  get; set; }

        public string cargo { get; set; }
    }
}
