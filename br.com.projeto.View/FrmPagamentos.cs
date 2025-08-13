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
    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            // Carrega tela
            TxtTroco.Text = "0,00";
            TxtDinheiro.Text = "0,00";
            TxtCartao.Text = "0,00";
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                v_dinheiro = Convert.ToDecimal(TxtDinheiro.Text);
                v_cartao = Convert.ToDecimal(TxtCartao.Text);
                total = Convert.ToDecimal(TxtTotal.Text);

                totalpago = v_dinheiro + v_cartao;

                if (totalpago < total)
                {
                    MessageBox.Show("Valor pago menor que o total da compra");
                    return;
                }
                else
                {
                    troco = totalpago - total;

                    Venda vendas = new Venda();
                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;
                    vendas.obs = TxtObs.Text;

                    VendaDAO vdao = new VendaDAO();
                    vdao.CadastrarVenda(vendas);
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Ocorreu um erro durante a execução do programa. Detalhes: {erro.Message}");
            }
        }
    }
}
