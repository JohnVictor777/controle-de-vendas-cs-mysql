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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método para cadastrar item da venda
        public void CadastrarItemVenda(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                        values(@venda_id,@produto_id,@qtd,@subtotal)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                cmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                cmd.Parameters.AddWithValue("@qtd", obj.qtd);
                cmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Venda cadastrada com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro durante a execução do programa. Detalhes: {erro.Message}");
            }
        }

        #endregion


    }
}
