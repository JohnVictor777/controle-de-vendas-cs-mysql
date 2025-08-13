using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.Model
{
    public class Funcionario : Cliente 
    {
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivel_acesso { get; set; }
    }
}
