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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        //Método para carregar os produtos
        private void CarregarProdutos()
        {
            ProdutoDAO dao = new ProdutoDAO();
            TabelaProduto.DataSource = dao.ListarProduto();
        }

        //Método para carregar os fornecedores
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //Carregar a combobox de fornecedores
            FornecedorDAO f_dao = new FornecedorDAO();
            CbFornecedor.DataSource = f_dao.ListarFornecedor();
            CbFornecedor.DisplayMember = "nome";
            CbFornecedor.ValueMember = "id";

            CarregarProdutos();
        }

        //Método para salvar o produto
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Armazenando os dados do produto
            try
            {
                //Validar campos obrigatórios
                if (string.IsNullOrWhiteSpace(TxtDescricao.Text) ||
                    string.IsNullOrWhiteSpace(TxtPreco.Text) ||
                    string.IsNullOrWhiteSpace(TxtQtdeEstoque.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }
                //Validar campos numéricos
                if (!decimal.TryParse(TxtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Preço inválido!");
                    return;
                }

                if (!int.TryParse(TxtQtdeEstoque.Text, out int qtdEstoque))
                {
                    MessageBox.Show("Quantidade de estoque inválida!");
                    return;
                }
                //Instanciar o objeto
                Produto obj = new Produto
                {
                    descricao = TxtDescricao.Text,
                    preco = preco,
                    qtdestoque = qtdEstoque,
                    for_id = Convert.ToInt32(CbFornecedor.SelectedValue)
                };

                //Chamar o método de cadastro
                ProdutoDAO dao = new ProdutoDAO();

                dao.CadastrarProduto(obj);
                CarregarProdutos();
                new Helpers().LimparTela(this);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para excluir o produto
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto obj = new Produto();
                obj.codigo = Convert.ToInt32(TxtCodigo.Text);

                ProdutoDAO dao = new ProdutoDAO();
                dao.ExcluirProduto(obj);

                CarregarProdutos();
                new Helpers().LimparTela(this);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o fornecedor! {erro.Message}");
            }
        }

        //Método para atualizar o produto
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar campos obrigatórios
                if (string.IsNullOrWhiteSpace(TxtDescricao.Text) ||
                    string.IsNullOrWhiteSpace(TxtPreco.Text) ||
                    string.IsNullOrWhiteSpace(TxtQtdeEstoque.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }
                //Validar campos numéricos
                if (!decimal.TryParse(TxtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Preço inválido!");
                    return;
                }

                if (!int.TryParse(TxtQtdeEstoque.Text, out int qtdEstoque))
                {
                    MessageBox.Show("Quantidade de estoque inválida!");
                    return;
                }

                Produto obj = new Produto()
                {
                    codigo = Convert.ToInt32(TxtCodigo.Text),
                    descricao = TxtDescricao.Text,
                    preco = Convert.ToDecimal(TxtPreco.Text),
                    qtdestoque = Convert.ToInt32(TxtQtdeEstoque.Text),
                    for_id = Convert.ToInt32(CbFornecedor.SelectedValue),
                };

                ProdutoDAO dao = new ProdutoDAO();
                dao.AtualizarProduto(obj);

                CarregarProdutos();
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Método para limpar os campos de texto
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            //Limpar os campos de texto
            new Helpers().LimparTela(this);
        }

        //Método para pesquisar por nome
        private void TxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Pesquisar por nome
            string nome = $"%{TxtPesquisa.Text}%";
            ProdutoDAO dao = new ProdutoDAO();

            //Pesquisar por nome
            TabelaProduto.DataSource = dao.ListarProdutoPorNome(nome);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtPesquisa.Text;
            ProdutoDAO dao = new ProdutoDAO();
            TabelaProduto.DataSource = dao.BuscarProdutoPorNome(nome);

            if (TabelaProduto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado!");
                CarregarProdutos();
            }
        }

        //Método para carregar os dados na tela
        private void TabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = TabelaProduto.CurrentRow.Cells[0].Value.ToString();
            TxtDescricao.Text = TabelaProduto.CurrentRow.Cells[1].Value.ToString();
            TxtPreco.Text = TabelaProduto.CurrentRow.Cells[2].Value.ToString();
            TxtQtdeEstoque.Text = TabelaProduto.CurrentRow.Cells[3].Value.ToString();

            //Carregar a combobox de fornecedores
            TabProduto.SelectedTab = tabPage1;
        }


        #region Ignorar
        private void TabelaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

    }
}
