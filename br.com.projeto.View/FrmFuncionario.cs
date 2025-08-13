using Controle_de_Vendas.br.com.projeto.Dao;
using Controle_de_Vendas.br.com.projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Controle_de_Vendas.br.com.projeto.View
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        //Método para carregar os funcionarios
        private void CarregarFuncionario()
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            TabelaFuncionario.DataSource = dao.ListarFuncionarios();
        }

        //Listar os funcionarios
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        //Método para botão novo
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            //Limpar a tela
            new Helpers().LimparTela(this);
        }

        //Método para salvar funcionario
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtCpf.Text) ||
                    string.IsNullOrWhiteSpace(TxtRg.Text) ||
                    string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                    string.IsNullOrWhiteSpace(TxtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(TxtCelular.Text) ||
                    string.IsNullOrWhiteSpace(TxtCep.Text) ||
                    string.IsNullOrWhiteSpace(TxtEndereco.Text) ||

                    string.IsNullOrWhiteSpace(TxtBairro.Text) ||
                    string.IsNullOrWhiteSpace(TxtCidade.Text) ||
                    string.IsNullOrWhiteSpace(CbUf.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                if (!int.TryParse(TxtNumero.Text, out int numero))
                {
                    MessageBox.Show("Insira um número!");
                    return;
                }
                //Armazenando os dados do funcionario
                Funcionario obj = new Funcionario()
                {
                    nome = TxtNome.Text,
                    rg = TxtRg.Text,
                    cpf = TxtCpf.Text,
                    email = TxtEmail.Text,
                    senha = TxtSenha.Text,
                    cargo = CbCargo.Text,
                    nivel_acesso = CbNivel.Text,
                    telefone = TxtTelefone.Text,
                    celular = TxtCelular.Text,
                    cep = TxtCep.Text,
                    endereco = TxtEndereco.Text,
                    numero = Convert.ToInt32(TxtNumero.Text),
                    complemento = TxtComplemento.Text,
                    bairro = TxtBairro.Text,
                    cidade = TxtCidade.Text,
                    estado = CbUf.Text,
                };

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.CadastrarFuncionario(obj);

                CarregarFuncionario();
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para buscar CEP
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            new Helpers().BuscarCep(TxtCep.Text, TxtEndereco, TxtBairro, TxtCidade, CbUf, TxtComplemento);
        }

        //Método para atualizar funcionario
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtCpf.Text) ||
                    string.IsNullOrWhiteSpace(TxtRg.Text) ||
                    string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                    string.IsNullOrWhiteSpace(TxtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(TxtCelular.Text) ||
                    string.IsNullOrWhiteSpace(TxtCep.Text) ||
                    string.IsNullOrWhiteSpace(TxtEndereco.Text) ||

                    string.IsNullOrWhiteSpace(TxtBairro.Text) ||
                    string.IsNullOrWhiteSpace(TxtCidade.Text) ||
                    string.IsNullOrWhiteSpace(CbUf.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                if (!int.TryParse(TxtNumero.Text, out int numero))
                {
                    MessageBox.Show("Insira um número!");
                    return;
                }

                //Armazenando os dados do funcionario
                Funcionario obj = new Funcionario()
                {
                    codigo = Convert.ToInt32(TxtCodigo.Text),
                    nome = TxtNome.Text,
                    rg = TxtRg.Text,
                    cpf = TxtCpf.Text,
                    email = TxtEmail.Text,
                    senha = TxtSenha.Text,
                    cargo = CbCargo.Text,
                    nivel_acesso = CbNivel.Text,
                    telefone = TxtTelefone.Text,
                    celular = TxtCelular.Text,
                    cep = TxtCep.Text,
                    endereco = TxtEndereco.Text,
                    numero = Convert.ToInt32(TxtNumero.Text),
                    complemento = TxtComplemento.Text,
                    bairro = TxtBairro.Text,
                    cidade = TxtCidade.Text,
                    estado = CbUf.Text,
                };

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.AtualizarFuncionario(obj);

                CarregarFuncionario();
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para excluir funcionario
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Armazenando os dados do funcionario
            Funcionario obj = new Funcionario();
            obj.codigo = Convert.ToInt32(TxtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(obj);
            CarregarFuncionario();
        }

        //Pegar os dados da tabela e jogar nos campos de texto
        private void TabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da tabela e jogar nos campos de texto
            TxtCodigo.Text = TabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = TabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            TxtRg.Text = TabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            TxtCpf.Text = TabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            TxtEmail.Text = TabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            TxtSenha.Text = TabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            CbCargo.Text = TabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            CbNivel.Text = TabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            TxtTelefone.Text = TabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            TxtCelular.Text = TabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            TxtCep.Text = TabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            TxtEndereco.Text = TabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            TxtNumero.Text = TabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            TxtComplemento.Text = TabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            TxtBairro.Text = TabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            TxtCidade.Text = TabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            CbUf.Text = TabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            //Mudar para a aba de cadastro
            TabFuncionario.SelectedTab = tabPage1;
        }

        //Pesquisar por nome
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtPesquisa.Text;
            FuncionarioDAO dao = new FuncionarioDAO();
            TabelaFuncionario.DataSource = dao.BuscarFuncionarioPorNome(nome);

            if (TabelaFuncionario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
                TabelaFuncionario.DataSource = dao.ListarFuncionarioPorNome(nome);
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = $"%{TxtPesquisa.Text}%";
            FuncionarioDAO dao = new FuncionarioDAO();

            TabelaFuncionario.DataSource = dao.ListarFuncionarioPorNome(nome);
        }

        #region Ignorar
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void TabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}