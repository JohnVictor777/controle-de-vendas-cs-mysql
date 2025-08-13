using Controle_de_Vendas.br.com.projeto.Conexao;
using Controle_de_Vendas.br.com.projeto.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.Dao
{
    public class FuncionarioDAO
    {
        //Conexão com o banco
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            //Instanciar a conexão
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método para cadastrar funcionario
        public void CadastrarFuncionario(Funcionario obj)
        {

            try
            {
                //Conectar ao banco
                string sql = @" insert into  tb_funcionarios(nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                            values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@rg", obj.rg);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@cargo", obj.cargo);
                cmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                MessageBox.Show("Funcionario cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar funcionario: {erro.Message}");
            }

        }
        #endregion

        #region Método para Atualizar funcionarios
        public void AtualizarFuncionario(Funcionario obj)
        {
            try
            {
                //Conectar ao banco
                string sql = @"update tb_funcionarios set nome = @nome, rg = @rg, cpf = @cpf, email = @email, senha = @senha,
                            cargo = @cargo, nivel_acesso = @nivel_acesso, telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";
                //Executar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@rg", obj.rg);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@cargo", obj.cargo);
                cmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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
                MessageBox.Show("Funcionario atualizado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao atualizar funcionario: {erro.Message}");
            }
        }
        #endregion

        #region Método para Listar funcionarios
        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelafuncionarios = new DataTable();
                string sql = @" SELECT f.id as 'Código',
	                                f.nome as 'Nome', f.rg as 'RG', f.cpf as 'CPF',
                                    f.email as 'E-mail', f.senha as 'Senha', f.cargo as 'Cargo',
                                    f.nivel_acesso as 'Acesso', f.telefone as 'Telefone',
                                    f.celular as 'Celular', f.cep as 'Cep', f.endereco as 'Endereço',
                                    f.numero as 'Nº', f.complemento as 'Complemento',
                                    f.bairro as 'Bairro', f.cidade as 'Cidade', f.estado as 'Estado'
                                 FROM bdvendas.tb_funcionarios as f";

                using(MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelafuncionarios);
                    }
                    conexao.Close();
                }

                return tabelafuncionarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao listar funcionarios{erro.Message}");
                return null;
            }

        }
        #endregion

        #region Método para Excluir funcionario
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.codigo);
                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir funcionario: {erro.Message} ");
            }


        }
        #endregion


        #region Método Listar Fucionario por Nome
        public DataTable ListarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionarios = new DataTable();
                string sql = @"select * from tb_funcionarios where nome like @nome";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                    conexao.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabelafuncionarios);
                    }
                    conexao.Close();
                }

                return tabelafuncionarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar funcionarios" + erro);
                return null;
            }
        }
        #endregion

        #region Metodo para buscar por Nome
        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = @"select tb_funcionarios where nome = @nome";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabelafuncionario);
                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar funcionario: " + erro);
                return null;
            }

        }
        #endregion
    }
}
