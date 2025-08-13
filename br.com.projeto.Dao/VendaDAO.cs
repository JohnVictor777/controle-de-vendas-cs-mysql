using Controle_de_Vendas.br.com.projeto.Conexao;
using Controle_de_Vendas.br.com.projeto.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.Dao
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // CADASTRO DE VENDAS 

        #region Cadastrar Venda

        public void CadastrarVenda(Venda obj)
        {
            try
            {
                // Criar o Sql
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) 
                                values(@cliente_id, @data_venda, @total_venda, @obs)";

                // Organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);

                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                // Abrir conexao e executar o comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda Cadastrada com Sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro durante a execução do programa. Detalhes: " + erro.Message);

            }
        }

        #endregion

        // VOLTAR ID DA ULTIMA VENDA

        #region Retornar Id da ultima venda

        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                // Criar o sql
                string sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                // Abrir a conexao e executar o comando
                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }

                conexao.Close();
                return idvenda;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro durante a execução do programa. Detalhes: " + erro.Message);
                conexao.Close();
                return 0;
            }
        }

        #endregion
    }
}


    
