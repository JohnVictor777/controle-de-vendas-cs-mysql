namespace Controle_de_Vendas.br.com.projeto.View
{
    partial class FrmPagamentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtCartao = new System.Windows.Forms.TextBox();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.TxtDinheiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 55);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE PAGAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 39);
            this.label6.TabIndex = 55;
            this.label6.Text = "Obs:";
            // 
            // TxtObs
            // 
            this.TxtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObs.Location = new System.Drawing.Point(593, 99);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(333, 231);
            this.TxtObs.TabIndex = 54;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.Navy;
            this.BtnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizar.Location = new System.Drawing.Point(253, 373);
            this.BtnFinalizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(420, 67);
            this.BtnFinalizar.TabIndex = 53;
            this.BtnFinalizar.Text = "FINALIZAR VENDA";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(253, 291);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(207, 39);
            this.TxtTotal.TabIndex = 52;
            // 
            // TxtCartao
            // 
            this.TxtCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCartao.Location = new System.Drawing.Point(253, 166);
            this.TxtCartao.Multiline = true;
            this.TxtCartao.Name = "TxtCartao";
            this.TxtCartao.Size = new System.Drawing.Size(207, 39);
            this.TxtCartao.TabIndex = 51;
            // 
            // TxtTroco
            // 
            this.TxtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTroco.Location = new System.Drawing.Point(253, 221);
            this.TxtTroco.Multiline = true;
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(207, 39);
            this.TxtTroco.TabIndex = 50;
            // 
            // TxtDinheiro
            // 
            this.TxtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDinheiro.Location = new System.Drawing.Point(253, 99);
            this.TxtDinheiro.Multiline = true;
            this.TxtDinheiro.Name = "TxtDinheiro";
            this.TxtDinheiro.Size = new System.Drawing.Size(207, 39);
            this.TxtDinheiro.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 39);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dinheiro (R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 39);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cartão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 46;
            this.label2.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 39);
            this.label5.TabIndex = 45;
            this.label5.Text = "Troco:";
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtCartao);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.TxtDinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "FrmPagamentos";
            this.Text = "FrmPagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Button BtnFinalizar;
        public System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtCartao;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.TextBox TxtDinheiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}