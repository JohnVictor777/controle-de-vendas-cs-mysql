namespace Controle_de_Vendas.br.com.projeto.View
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabProduto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.CbFornecedor = new System.Windows.Forms.ComboBox();
            this.TxtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TabelaProduto = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabProduto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 55);
            this.panel1.TabIndex = 1;
            // 
            // TabProduto
            // 
            this.TabProduto.Controls.Add(this.tabPage1);
            this.TabProduto.Controls.Add(this.tabPage2);
            this.TabProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabProduto.Location = new System.Drawing.Point(3, 61);
            this.TabProduto.Name = "TabProduto";
            this.TabProduto.SelectedIndex = 0;
            this.TabProduto.Size = new System.Drawing.Size(801, 342);
            this.TabProduto.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtPreco);
            this.tabPage1.Controls.Add(this.CbFornecedor);
            this.tabPage1.Controls.Add(this.TxtQtdeEstoque);
            this.tabPage1.Controls.Add(this.TxtDescricao);
            this.tabPage1.Controls.Add(this.TxtCodigo);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtPreco
            // 
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(613, 184);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(157, 26);
            this.TxtPreco.TabIndex = 30;
            // 
            // CbFornecedor
            // 
            this.CbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFornecedor.FormattingEnabled = true;
            this.CbFornecedor.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CbFornecedor.Location = new System.Drawing.Point(136, 76);
            this.CbFornecedor.Name = "CbFornecedor";
            this.CbFornecedor.Size = new System.Drawing.Size(348, 28);
            this.CbFornecedor.TabIndex = 29;
            // 
            // TxtQtdeEstoque
            // 
            this.TxtQtdeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQtdeEstoque.Location = new System.Drawing.Point(147, 135);
            this.TxtQtdeEstoque.Name = "TxtQtdeEstoque";
            this.TxtQtdeEstoque.Size = new System.Drawing.Size(190, 26);
            this.TxtQtdeEstoque.TabIndex = 27;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(124, 184);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(358, 26);
            this.TxtDescricao.TabIndex = 20;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(97, 24);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Preço (R$):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qtd. Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnPesquisar);
            this.tabPage2.Controls.Add(this.TxtPesquisa);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.TabelaProduto);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Location = new System.Drawing.Point(599, 14);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(150, 43);
            this.BtnPesquisar.TabIndex = 20;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisa.Location = new System.Drawing.Point(88, 22);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(497, 26);
            this.TxtPesquisa.TabIndex = 19;
            this.TxtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesquisa_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "Nome:";
            // 
            // TabelaProduto
            // 
            this.TabelaProduto.AllowUserToAddRows = false;
            this.TabelaProduto.AllowUserToDeleteRows = false;
            this.TabelaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaProduto.Location = new System.Drawing.Point(6, 66);
            this.TabelaProduto.Name = "TabelaProduto";
            this.TabelaProduto.ReadOnly = true;
            this.TabelaProduto.Size = new System.Drawing.Size(781, 243);
            this.TabelaProduto.TabIndex = 2;
            this.TabelaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProduto_CellClick);
            this.TabelaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProduto_CellContentClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Navy;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(541, 411);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(130, 43);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.Navy;
            this.BtnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(405, 411);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(130, 43);
            this.BtnAtualizar.TabIndex = 8;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Navy;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(267, 411);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(130, 43);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Navy;
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(131, 411);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(130, 43);
            this.BtnNovo.TabIndex = 6;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabProduto);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabProduto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabProduto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CbFornecedor;
        private System.Windows.Forms.TextBox TxtQtdeEstoque;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView TabelaProduto;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.TextBox TxtPreco;
    }
}