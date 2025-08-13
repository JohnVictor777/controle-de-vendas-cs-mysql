namespace Controle_de_Vendas.br.com.projeto.View
{
    partial class FrmFornecedor
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
            this.TabFornecedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CbUf = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TabelaFornecedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TabFornecedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFornecedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabFornecedor
            // 
            this.TabFornecedor.Controls.Add(this.tabPage1);
            this.TabFornecedor.Controls.Add(this.tabPage2);
            this.TabFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabFornecedor.Location = new System.Drawing.Point(4, 59);
            this.TabFornecedor.Name = "TabFornecedor";
            this.TabFornecedor.SelectedIndex = 0;
            this.TabFornecedor.Size = new System.Drawing.Size(893, 403);
            this.TabFornecedor.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtCnpj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtCep);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtCelular);
            this.tabPage1.Controls.Add(this.TxtTelefone);
            this.tabPage1.Controls.Add(this.CbUf);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.TxtEndereco);
            this.tabPage1.Controls.Add(this.TxtCidade);
            this.tabPage1.Controls.Add(this.TxtComplemento);
            this.tabPage1.Controls.Add(this.TxtNome);
            this.tabPage1.Controls.Add(this.TxtNumero);
            this.tabPage1.Controls.Add(this.TxtCodigo);
            this.tabPage1.Controls.Add(this.TxtBairro);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtCnpj
            // 
            this.TxtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCnpj.Location = new System.Drawing.Point(524, 110);
            this.TxtCnpj.Mask = "##.###.###/####-##";
            this.TxtCnpj.Name = "TxtCnpj";
            this.TxtCnpj.Size = new System.Drawing.Size(162, 26);
            this.TxtCnpj.TabIndex = 35;
            this.TxtCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtCnpj_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "CNPJ:";
            // 
            // TxtCep
            // 
            this.TxtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCep.Location = new System.Drawing.Point(73, 239);
            this.TxtCep.Mask = "#####-###";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(96, 26);
            this.TxtCep.TabIndex = 33;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(172, 232);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 40);
            this.BtnBuscar.TabIndex = 32;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(535, 158);
            this.TxtCelular.Mask = "(99) 0 0000-0000";
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(135, 26);
            this.TxtCelular.TabIndex = 31;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(111, 160);
            this.TxtTelefone.Mask = "(99) 0000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(130, 26);
            this.TxtTelefone.TabIndex = 30;
            // 
            // CbUf
            // 
            this.CbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUf.FormattingEnabled = true;
            this.CbUf.Items.AddRange(new object[] {
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
            this.CbUf.Location = new System.Drawing.Point(381, 239);
            this.CbUf.Name = "CbUf";
            this.CbUf.Size = new System.Drawing.Size(121, 28);
            this.CbUf.TabIndex = 29;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(89, 110);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(327, 26);
            this.TxtEmail.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cidade:";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndereco.Location = new System.Drawing.Point(530, 293);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(335, 26);
            this.TxtEndereco.TabIndex = 24;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(98, 291);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(271, 26);
            this.TxtCidade.TabIndex = 23;
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComplemento.Location = new System.Drawing.Point(475, 335);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(390, 26);
            this.TxtComplemento.TabIndex = 22;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(88, 65);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(598, 26);
            this.TxtNome.TabIndex = 20;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(107, 329);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(109, 26);
            this.TxtNumero.TabIndex = 19;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(51, 24);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 18;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(649, 245);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(216, 26);
            this.TxtBairro.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(335, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 24);
            this.label16.TabIndex = 13;
            this.label16.Text = "Complemento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(579, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(338, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "UF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(455, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnPesquisar);
            this.tabPage2.Controls.Add(this.TxtPesquisa);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.TabelaFornecedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 374);
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
            // TabelaFornecedor
            // 
            this.TabelaFornecedor.AllowUserToAddRows = false;
            this.TabelaFornecedor.AllowUserToDeleteRows = false;
            this.TabelaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaFornecedor.Location = new System.Drawing.Point(6, 66);
            this.TabelaFornecedor.Name = "TabelaFornecedor";
            this.TabelaFornecedor.ReadOnly = true;
            this.TabelaFornecedor.Size = new System.Drawing.Size(873, 302);
            this.TabelaFornecedor.TabIndex = 2;
            this.TabelaFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaFornecedor_CellClick);
            this.TabelaFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaFornecedor_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FORNECEDOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 55);
            this.panel1.TabIndex = 2;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Navy;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(600, 474);
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
            this.BtnAtualizar.Location = new System.Drawing.Point(464, 474);
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
            this.BtnSalvar.Location = new System.Drawing.Point(326, 474);
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
            this.BtnNovo.Location = new System.Drawing.Point(190, 474);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(130, 43);
            this.BtnNovo.TabIndex = 6;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabFornecedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.TabFornecedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFornecedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabFornecedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox TxtCep;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.MaskedTextBox TxtCelular;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.ComboBox CbUf;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView TabelaFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.MaskedTextBox TxtCnpj;
        private System.Windows.Forms.Label label2;
    }
}