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
    public partial class FrmVendas : Form
    {
        // Instanciando as classes Cliente e ClienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        // Instanciando as classes Produto e ProdutoDAO
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        // Variáveis para armazenar os valores dos campos   
        int qtd;
        decimal preco;
        decimal subtotal, total;

        // DataTable para armazenar os itens do carrinho
        DataTable carrinho = new DataTable();

        // Método para limpar os campos
        private void LimparCampos()
        {
            TxtCodigo.Clear();
            TxtDescricao.Clear();
            TxtPreco.Clear();
            TxtQtd.Clear();
        }

        // Método para preencher os campos do produto
        private void PreencherCamposProduto(Produto produto)
        {
            TxtDescricao.Text = produto.descricao;
            TxtPreco.Text = produto.preco.ToString();
        }

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        // Método para carregar o formulário
        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é o Enter
            if (e.KeyChar == (char)Keys.Enter) 
            {
                string cpf = TxtCpf.Text.Trim();

                if (!string.IsNullOrEmpty(cpf)) 
                {
                    cliente = cdao.RetornaClientePorCpf(cpf);

                    if (cliente != null) 
                    {
                        TxtNome.Text = cliente.nome;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um CPF válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Método para adicionar o produto ao carrinho
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é o Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                int codigo;
                if (int.TryParse(TxtCodigo.Text, out codigo))
                {
                    p = pdao.RetornaProdutoPorCodigo(codigo);

                    if (p != null) // Verifica se o produto foi encontrado
                    {
                        PreencherCamposProduto(p);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um código válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #region Ignorar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        #endregion

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            TxtData.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(TxtQtd.Text);
                preco = decimal.Parse(TxtPreco.Text);


                subtotal = qtd * preco;

                total += subtotal;

                // Adicionar o produto no carrinho
                carrinho.Rows.Add(int.Parse(TxtCodigo.Text), TxtDescricao.Text, qtd, preco, subtotal);

                TxtTotal.Text = total.ToString();

                // Limpar os campos
                LimparCampos();

                TxtCodigo.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro durante a execução do programa. Detalhes: {erro.Message}");
            }

        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
                int indice = tabelaProdutos.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();
                total -= subproduto;
                TxtTotal.Text = total.ToString();

                MessageBox.Show("Produto removido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro durante a execução do programa. Detalhes: {erro.Message}");
            }
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(TxtData.Text);
            FrmPagamentos tela = new FrmPagamentos(cliente,carrinho, dataatual);
            tela.TxtTotal.Text = total.ToString();
            tela.ShowDialog();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
