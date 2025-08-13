using Controle_de_Vendas.br.com.projeto.Dao;
using Controle_de_Vendas.br.com.projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.View
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        //Método para carregar os produtos
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        //Método para carregar os produtos
        private void CarregarProdutos()
        {
            ClienteDAO dao = new ClienteDAO();
            TabelaCliente.DataSource = dao.ListarClientes();
        }

        //Método para salvar o cliente
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Armazenando os dados do cliente
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtRg.Text) ||
                    string.IsNullOrWhiteSpace(TxtCpf.Text) ||
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

                Cliente obj = new Cliente()
                {
                    nome = TxtNome.Text,
                    rg = TxtRg.Text,
                    cpf = TxtCpf.Text,
                    email = TxtEmail.Text,
                    telefone = TxtTelefone.Text,
                    celular = TxtCelular.Text,
                    cep = TxtCep.Text,
                    endereco = TxtEndereco.Text,
                    numero = numero,
                    complemento = TxtComplemento.Text,
                    bairro = TxtBairro.Text,
                    cidade = TxtCidade.Text,
                    estado = CbUf.Text
                };

                ClienteDAO dao = new ClienteDAO();
                dao.CadastrarCliente(obj);

                CarregarProdutos();
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para atualizar o cliente
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtRg.Text) ||
                    string.IsNullOrWhiteSpace(TxtCpf.Text) ||
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

                Cliente obj = new Cliente()
                {
                    nome = TxtNome.Text,
                    rg = TxtRg.Text,
                    cpf = TxtCpf.Text,
                    email = TxtEmail.Text,
                    telefone = TxtTelefone.Text,
                    celular = TxtCelular.Text,
                    cep = TxtCep.Text,
                    endereco = TxtEndereco.Text,
                    numero = Convert.ToInt32(TxtNumero.Text),
                    complemento = TxtComplemento.Text,
                    bairro = TxtBairro.Text,
                    cidade = TxtCidade.Text,
                    estado = CbUf.Text,
                    codigo = Convert.ToInt32(TxtCodigo.Text),
                };
                ClienteDAO dao = new ClienteDAO();
                dao.AtualizarCliente(obj);

                CarregarProdutos();
                //Limpar os campos de texto
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para excluir o cliente
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente();
                obj.codigo = Convert.ToInt32(TxtCodigo.Text);

                ClienteDAO dao = new ClienteDAO();
                dao.ExcluirCliente(obj);

                CarregarProdutos();
                new Helpers().LimparTela(this);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o Cliente! {erro.Message}");
            }
        }

        //Método para carregar os dados da tabela para os campos de texto
        private void TabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da tabela e jogar nos campos de texto
            TxtCodigo.Text = TabelaCliente.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = TabelaCliente.CurrentRow.Cells[1].Value.ToString();
            TxtRg.Text = TabelaCliente.CurrentRow.Cells[2].Value.ToString();
            TxtCpf.Text = TabelaCliente.CurrentRow.Cells[3].Value.ToString();
            TxtEmail.Text = TabelaCliente.CurrentRow.Cells[4].Value.ToString();
            TxtTelefone.Text = TabelaCliente.CurrentRow.Cells[5].Value.ToString();
            TxtCelular.Text = TabelaCliente.CurrentRow.Cells[6].Value.ToString();
            TxtCep.Text = TabelaCliente.CurrentRow.Cells[7].Value.ToString();
            TxtEndereco.Text = TabelaCliente.CurrentRow.Cells[8].Value.ToString();
            TxtNumero.Text = TabelaCliente.CurrentRow.Cells[9].Value.ToString();
            TxtComplemento.Text = TabelaCliente.CurrentRow.Cells[10].Value.ToString();
            TxtBairro.Text = TabelaCliente.CurrentRow.Cells[11].Value.ToString();
            TxtCidade.Text = TabelaCliente.CurrentRow.Cells[12].Value.ToString();
            CbUf.Text = TabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Mudar para a aba de cadastro
            TabClientes.SelectedTab = tabPage1;
        }

        //Método para pesquisar o cliente
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtPesquisa.Text;
            ClienteDAO dao = new ClienteDAO();
            TabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            //Verificar se a tabela está vazia
            if (TabelaCliente.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
                CarregarProdutos();
            }
        }

        //Método para pesquisar o cliente
        private void TxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = $"%{TxtPesquisa.Text}%";
            CarregarProdutos();
        }

        //Método para buscar o CEP
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            new Helpers().BuscarCep(TxtCep.Text, TxtEndereco, TxtBairro, TxtCidade, CbUf, TxtComplemento);
        }

        //Método para limpar os campos de texto
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        #region Ignore

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

    }
}
