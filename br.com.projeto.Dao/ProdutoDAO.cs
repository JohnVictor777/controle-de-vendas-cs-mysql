﻿using Controle_de_Vendas.br.com.projeto.Conexao;
using Controle_de_Vendas.br.com.projeto.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.Dao
{
    public class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region Cadastrar Produto
        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id) 
                                values (@descricao, @preco, @qtd_estoque, @for_id)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                cmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: {erro.Message}");
            }
        }
        #endregion

        #region Listar Produtos
        public DataTable ListarProduto()
        {
            try
            {
                DataTable tabelaprodutos = new DataTable();
                string sql = @"select p.id as 'Código',
	                                  p.descricao as 'Descrição',
	                                  p.preco as 'Preço',
	                                  p.qtd_estoque as 'Qtd Estoque',
	                                  f.nome as 'Fornecedor' from tb_produtos as p
	                                  join tb_fornecedores as f on (p.for_id = f.id);";

                //Abrir a conexão
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelaprodutos);
                    }
                    conexao.Close();
                }
                //Retornar a tabela
                return tabelaprodutos;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar os produtos: {erro.Message}");
                return null;
            }
        }
        #endregion

        #region Atualizar Produto
        public void AtualizarProduto(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao = @descricao, preco = @preco, qtd_estoque = @qtd_estoque, for_id = @for_id 
                               where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdestoque);
                cmd.Parameters.AddWithValue("@for_id", obj.for_id);
                cmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto atualizado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao atualizar o produto: {erro.Message}");
            }
        }
        #endregion

        #region Excluir Produto
        public void ExcluirProduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_produtos where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o produto: {erro.Message}");
            }
        }
        #endregion


        #region Listar Produto por Nome
        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {

                DataTable tabelaproduto = new DataTable();
                string sql = @"select * from tb_produtos where descricao like @descricao";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@descricao", $"%{nome}%");
                    conexao.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelaproduto);
                    }
                    conexao.Close();
                }

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar os produtos: {erro.Message}");
                return null;
            }
        }
        #endregion

        #region Buscar Produto por Nome
        public DataTable BuscarProdutoPorNome(string nome)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = @"select * from tb_produtos where descricao = @descricao";


                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@descricao", $"%{nome}%");
                    conexao.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelaproduto);
                    }
                    conexao.Close();
                }

                return tabelaproduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao buscar o produto: {erro.Message}");
                return null;
            }
        }
        #endregion


        #region Retorna produto por código
        public Produto RetornaProdutoPorCodigo(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.codigo = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");

                    return p;
                }
                else
                {
                    MessageBox.Show($"Nenhum produto encontrado com esse código!");
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu o erro: {erro.Message}");
                return null;
            }
        }

        #endregion

        /*
         #region Buscar Produto por Fornecedor
         public DataTable BuscarProdutoPorFornecedor(string nome)
         {
             try
             {
                 string sql = @"select * from tb_produtos where for_id like @for_id";
                 MySqlCommand cmd = new MySqlCommand(sql, conexao);
                 cmd.Parameters.AddWithValue("@for_id", nome);
                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception erro)
             {
                 MessageBox.Show($"Erro ao buscar o produto: {erro.Message}");
                 return null;
             }
         }
         #endregion

         #region Buscar Produto por Código
         public DataTable BuscarProdutoPorCodigo(int codigo)
         {
             try
             {
                 string sql = @"select * from tb_produtos where codigo = @codigo";
                 MySqlCommand cmd = new MySqlCommand(sql, conexao);
                 cmd.Parameters.AddWithValue("@codigo", codigo);
                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception erro)
             {
                 MessageBox.Show($"Erro ao buscar o produto: {erro.Message}");
                 return null;
             }
         }
         #endregion
         */

    }
}
