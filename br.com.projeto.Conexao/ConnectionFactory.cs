using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.Conexao
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
