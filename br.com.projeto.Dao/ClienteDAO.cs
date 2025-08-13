using Controle_de_Vendas.br.com.projeto.Conexao;
using Controle_de_Vendas.br.com.projeto.Model;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.Dao
{
    class ClienteDAO
    {

        private MySqlConnection conexao;
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region Cadastrar Cliente
        public void CadastrarCliente(Cliente obj)
        {

            try
            {
                //Conectar ao banco
                string sql = @" insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                            values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
                //Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@rg", obj.rg);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                //Abrir a conexão
                conexao.Open();
                //Executar o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {erro.Message}");
            }


        }
        #endregion

        #region Listar Cliente
        public DataTable ListarClientes()
        {
            try
            {
                //Conectar ao banco
                DataTable tabelaclientes = new DataTable();
                string sql = @"SELECT c.id as 'Código', c.nome as 'Nome',
                                      c.rg as 'RG', c.cpf as 'CPF',
                                      c.email as 'E-mail', c.telefone as 'Telefone',
                                      c.celular as 'Celular', c.cep as 'Cep',
                                      c.endereco as 'Endereço', c.numero as 'Nº',
                                      c.complemento as 'Complemento', c.bairro as 'Bairro',
                                      c.cidade as 'Cidade', c.estado as 'Estado'
                                     FROM bdvendas.tb_clientes as c";
                //Executar o comando SQL
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao)) 
                {
                    conexao.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelaclientes);
                    }
                conexao.Close();
                }
                return tabelaclientes;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar clientes: {erro.Message}");
                return null;
            }
        }
        #endregion

        #region Atualizar Cliente
        public void AtualizarCliente(Cliente obj)
        {
            try
            {
                //Conectar ao banco
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular,
                                cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                where id=@id";
                //Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@rg", obj.rg);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                //Abrir a conexão
                conexao.Open();
                //Executar o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao atualizar cliente: {erro.Message}");
            }

        }

        #endregion

        #region Excluir Cliente
        public void ExcluirCliente(Cliente obj)
        {

            try
            {
                //Conectar ao banco
                string sql = @"delete from tb_clientes where id=@id";

                //Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.codigo);

                //Abrir a conexão
                conexao.Open();
                //Executar o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao excluir cliente: {erro.Message}");
            }


        }
        #endregion


        #region Buscar Cliente por Nome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //DataTable e o comando sql
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes where nome = @nome";


                //Organizar e executar comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar MySQLDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a conexao
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }

        }
        #endregion

        #region Listar Cliente por Nome
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                //DataTable e o comando sql
                DataTable tabelacliente = new DataTable();

                string sql = "select * from tb_clientes where nome like @nome";


                //Organizar e executar comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open(); 
                executacmd.ExecuteNonQuery();

                //Criar MySQLDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a conexao
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);

                return null;
            }

        }
        #endregion


        #region Retorna Cliente por Cpf
        public Cliente RetornaClientePorCpf(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();
                string sql = "select * from tb_clientes where cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();
                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    obj.codigo = rs.GetInt32("id");
                    obj.nome = rs.GetString("nome");
               
                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro: {erro.Message}");
                return null;
            }

        }
        #endregion
    }
}
