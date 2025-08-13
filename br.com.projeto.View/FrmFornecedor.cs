using Controle_de_Vendas.br.com.projeto.Dao;
using Controle_de_Vendas.br.com.projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.View
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        //Método para carregar os fornecedores
        private void CarregarFornecedor()
        {
            FornecedorDAO dao = new FornecedorDAO();
            TabelaFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }

        //Método para salvar o fornecedor
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtCnpj.Text) ||
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

                Fornecedor obj = new Fornecedor()
                {
                    nome = TxtNome.Text,
                    cnpj = TxtCnpj.Text,
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
                };

                FornecedorDAO dao = new FornecedorDAO();
                dao.CadastrarFornecedor(obj);

                CarregarFornecedor();
                new Helpers().LimparTela(this);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para excluir o fornecedor
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor obj = new Fornecedor();
                obj.codigo = Convert.ToInt32(TxtCodigo.Text);

                FornecedorDAO dao = new FornecedorDAO();
                dao.ExcluirFornecedor(obj);

                CarregarFornecedor();
                new Helpers().LimparTela(this);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir o fornecedor! {erro.Message}");
            }
            
        }

        //Método para atualizar o fornecedor
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                    string.IsNullOrWhiteSpace(TxtCnpj.Text) ||
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

                Fornecedor obj = new Fornecedor()
                {
                    nome = TxtNome.Text,
                    cnpj = TxtCnpj.Text,
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
                
                FornecedorDAO dao = new FornecedorDAO();
                dao.AtualizarFornecedor(obj);

                CarregarFornecedor();
                new Helpers().LimparTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para selecionar o fornecedor
        private void TabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da tabela e jogar nos campos de texto
            TxtCodigo.Text = TabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            TxtNome.Text = TabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            TxtCnpj.Text = TabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            TxtEmail.Text = TabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            TxtTelefone.Text = TabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            TxtCelular.Text = TabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            TxtCep.Text = TabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            TxtEndereco.Text = TabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            TxtNumero.Text = TabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            TxtComplemento.Text = TabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            TxtBairro.Text = TabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            TxtCidade.Text = TabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            CbUf.Text = TabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            //Mudar para a aba de cadastro
            TabFornecedor.SelectedTab = tabPage1;
        }

        //Método para botão novo
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        //Método para pesquisar por nome
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            new Helpers().BuscarCep(TxtCep.Text, TxtEndereco, TxtBairro, TxtCidade, CbUf, TxtComplemento);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtPesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();
            TabelaFornecedor.DataSource = dao.BuscarFornecedorPorNome(nome);

            if (TabelaFornecedor.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!");
                TabelaFornecedor.DataSource = dao.ListarFornecedorPorNome(nome);
            }
        }

        private void TxtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Pesquisar por nome
            string nome = $"%{TxtPesquisa.Text}%";
            FornecedorDAO dao = new FornecedorDAO();

            //Pesquisar por nome
            TabelaFornecedor.DataSource = dao.ListarFornecedorPorNome(nome);
        }


        #region ignorar
        private void TxtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtConsultar_Click(object sender, EventArgs e)
        {

        }

        private void TxtConsultar_Click_1(object sender, EventArgs e)
        {

        }

        private void TabelaFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

    }
}
