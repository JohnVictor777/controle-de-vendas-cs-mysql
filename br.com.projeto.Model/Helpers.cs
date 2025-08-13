using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.projeto.Model
{
    public class Helpers
    {
        #region Método para limpar os campos de texto
        public void LimparTela(Form tela)
        {
            //Limpar os campos de texto
            foreach (Control ctrPai in tela.Controls)
            {
                //Percorre os controles do form
                foreach (Control ctrl in ctrPai.Controls)
                {
                    //Percorre os controles do panel
                    if (ctrl is TabPage)
                    {
                        //Percorre os controles do panel
                        foreach (Control ctr2 in ctrl.Controls)
                        {

                            #region Percorre os controles do panel
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty;
                            }

                            if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }

                            if (ctr2 is ComboBox)
                            {
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                            #endregion

                        }
                    }
                }
            }
        }
        #endregion
        public void BuscarCep(string cep, TextBox txtEndereco, TextBox txtBairro, TextBox txtCidade, ComboBox cbUf, TextBox txtComplemento)
        {

            try
            {
                //Buscar o CEP
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";
                //Ler o XML
                DataSet dados = new DataSet();
                dados.ReadXml(xml);
                //Preencher os campos de texto
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar CEP: " + erro);

            }
        }

    

    }
}
