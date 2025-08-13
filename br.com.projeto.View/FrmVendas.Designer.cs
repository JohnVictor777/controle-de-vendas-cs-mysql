namespace Controle_de_Vendas.br.com.projeto.View
{
    partial class FrmVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtQtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnPagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 55);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtData);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCpf);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(86, 97);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(136, 26);
            this.TxtData.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Data:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(87, 20);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(414, 26);
            this.TxtNome.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "CPF:";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpf.Location = new System.Drawing.Point(86, 57);
            this.TxtCpf.Mask = "###.###.###-##";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(136, 26);
            this.TxtCpf.TabIndex = 16;
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRemover);
            this.groupBox2.Controls.Add(this.BtnAdicionar);
            this.groupBox2.Controls.Add(this.TxtPreco);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtQtd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtDescricao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BtnRemover
            // 
            this.BtnRemover.BackColor = System.Drawing.Color.Navy;
            this.BtnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.ForeColor = System.Drawing.Color.White;
            this.BtnRemover.Location = new System.Drawing.Point(243, 194);
            this.BtnRemover.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(130, 43);
            this.BtnRemover.TabIndex = 34;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.Navy;
            this.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ForeColor = System.Drawing.Color.White;
            this.BtnAdicionar.Location = new System.Drawing.Point(107, 194);
            this.BtnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(130, 43);
            this.BtnAdicionar.TabIndex = 33;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // TxtPreco
            // 
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(122, 143);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(157, 26);
            this.TxtPreco.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Preço (R$):";
            // 
            // TxtQtd
            // 
            this.TxtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQtd.Location = new System.Drawing.Point(55, 95);
            this.TxtQtd.Name = "TxtQtd";
            this.TxtQtd.Size = new System.Drawing.Size(132, 26);
            this.TxtQtd.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Qtd:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(108, 57);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(385, 26);
            this.TxtDescricao.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descrição:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(87, 19);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 20;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Código:";
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(532, 69);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.Size = new System.Drawing.Size(493, 327);
            this.tabelaProdutos.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(532, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(228, 27);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(200, 40);
            this.TxtTotal.TabIndex = 22;
            this.TxtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total (R$):";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(800, 489);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 60);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnPagamento
            // 
            this.BtnPagamento.BackColor = System.Drawing.Color.Green;
            this.BtnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagamento.ForeColor = System.Drawing.Color.White;
            this.BtnPagamento.Location = new System.Drawing.Point(625, 489);
            this.BtnPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPagamento.Name = "BtnPagamento";
            this.BtnPagamento.Size = new System.Drawing.Size(160, 60);
            this.BtnPagamento.TabIndex = 8;
            this.BtnPagamento.Text = "Pagamento";
            this.BtnPagamento.UseVisualStyleBackColor = false;
            this.BtnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnPagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnPagamento;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label label9;
    }
}