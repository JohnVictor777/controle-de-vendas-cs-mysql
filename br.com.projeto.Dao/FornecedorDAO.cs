using Controle_de_Vendas.br.com.projeto.Conexao;
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
    public class FornecedorDAO
    {

        private MySqlConnection conexao;
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Fornecedor
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //Conectar ao banco de dados
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone,celular, cep, endereco, numero,complemento, bairro, cidade,estado) 
                            values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@cep", obj.cep);
                cmd.Parameters.AddWithValue("@endereco", obj.endereco);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@complemento", obj.complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@estado", obj.estado);

                //Abrir conexão
                conexao.Open();

                //Executar o comando    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($" Erro ao cadastrar o fornecedor: {erro.Message}");
            }
        }
        #endregion

        #region Atualizar Fornecedor
        public void AtualizarFornecedor(Fornecedor obj)
        {
            try
            {
                //Conectar ao banco de dados
                string sql = @"update tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, 
                                numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade,estado=@estado where id=@id";

                // Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@cep", obj.cep);
                cmd.Parameters.AddWithValue("@endereco", obj.endereco);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@complemento", obj.complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@id", obj.codigo);
                //Abrir conexão
                conexao.Open();

                //Executar o comando    
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor atualizado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($" Erro ao atualizar o fornecedor: {erro.Message}");
            }
        }
        #endregion

        #region Excluir Fornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o fornecedor: {erro.Message}");
            }

        }
        #endregion

        #region Listar Fornecedores
        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = @" SELECT f.id as 'Código',
	                                f.nome as 'Nome', f.cnpj as 'CNPJ', f.email as 'E-mail',
                                    f.telefone as 'Telefone', f.celular as 'Celular',
                                    f.cep as 'Cep', f.endereco as 'Endereço', f.numero as 'Nº',
                                    f.complemento as 'Complemento', f.bairro as 'Bairro',
                                    f.cidade as 'Cidade', f.estado as 'Estado'
                                 FROM bdvendas.tb_fornecedores as f";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelafornecedor);
                    }
                    conexao.Close();
                }
                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar fornecedor {erro.Message}");
                return null;
            }
        }
        #endregion



        #region Listar Fornecedores Por Nome
        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                    conexao.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelafornecedor);
                    }
                    conexao.Close();
                }
                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar fornecedor {erro.Message}");
                return null;
            }
        }
        #endregion

        #region Buscar Fornecedores Por Nome
        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                using(MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                    conexao.Open();
                    using(MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelafornecedor);
                    }
                    conexao.Close();
                }
                return tabelafornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao buscar fornecedor {erro.Message}");
                return null;
            }
        }
        #endregion


    }
}
