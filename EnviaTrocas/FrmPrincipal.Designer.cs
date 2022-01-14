
namespace EnviaTrocas
{
    partial class FrmPrincipal
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
            this.tbcTroca = new System.Windows.Forms.TabControl();
            this.tblRegistrarTroca = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.MaskedTextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodeItens = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantiti = new System.Windows.Forms.TextBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProvider = new System.Windows.Forms.Button();
            this.txtNameProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodeExchange = new System.Windows.Forms.TextBox();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.tblProduto = new System.Windows.Forms.TabPage();
            this.tblFornecedor = new System.Windows.Forms.TabPage();
            this.tbcTroca.SuspendLayout();
            this.tblRegistrarTroca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTroca
            // 
            this.tbcTroca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTroca.Controls.Add(this.tblRegistrarTroca);
            this.tbcTroca.Controls.Add(this.tblProduto);
            this.tbcTroca.Controls.Add(this.tblFornecedor);
            this.tbcTroca.Location = new System.Drawing.Point(12, 12);
            this.tbcTroca.Name = "tbcTroca";
            this.tbcTroca.SelectedIndex = 0;
            this.tbcTroca.Size = new System.Drawing.Size(1077, 499);
            this.tbcTroca.TabIndex = 0;
            // 
            // tblRegistrarTroca
            // 
            this.tblRegistrarTroca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblRegistrarTroca.Controls.Add(this.pictureBox);
            this.tblRegistrarTroca.Controls.Add(this.label8);
            this.tblRegistrarTroca.Controls.Add(this.dtData);
            this.tblRegistrarTroca.Controls.Add(this.btnExchange);
            this.tblRegistrarTroca.Controls.Add(this.label7);
            this.tblRegistrarTroca.Controls.Add(this.txtCodeItens);
            this.tblRegistrarTroca.Controls.Add(this.btnSave);
            this.tblRegistrarTroca.Controls.Add(this.btnPrinter);
            this.tblRegistrarTroca.Controls.Add(this.btnCancel);
            this.tblRegistrarTroca.Controls.Add(this.btnAdd);
            this.tblRegistrarTroca.Controls.Add(this.label5);
            this.tblRegistrarTroca.Controls.Add(this.txtQuantiti);
            this.tblRegistrarTroca.Controls.Add(this.btnProduct);
            this.tblRegistrarTroca.Controls.Add(this.label4);
            this.tblRegistrarTroca.Controls.Add(this.txtNameProduct);
            this.tblRegistrarTroca.Controls.Add(this.txtCodeProduct);
            this.tblRegistrarTroca.Controls.Add(this.label3);
            this.tblRegistrarTroca.Controls.Add(this.btnProvider);
            this.tblRegistrarTroca.Controls.Add(this.txtNameProvider);
            this.tblRegistrarTroca.Controls.Add(this.label2);
            this.tblRegistrarTroca.Controls.Add(this.txtCodeProvider);
            this.tblRegistrarTroca.Controls.Add(this.label1);
            this.tblRegistrarTroca.Controls.Add(this.label6);
            this.tblRegistrarTroca.Controls.Add(this.txtCodeExchange);
            this.tblRegistrarTroca.Controls.Add(this.dgvRegister);
            this.tblRegistrarTroca.Location = new System.Drawing.Point(4, 22);
            this.tblRegistrarTroca.Name = "tblRegistrarTroca";
            this.tblRegistrarTroca.Padding = new System.Windows.Forms.Padding(3);
            this.tblRegistrarTroca.Size = new System.Drawing.Size(1069, 473);
            this.tblRegistrarTroca.TabIndex = 0;
            this.tblRegistrarTroca.Text = "Registrar Trocas";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::EnviaTrocas.Properties.Resources.troca1;
            this.pictureBox.Location = new System.Drawing.Point(922, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 109);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cód. Troca";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(103, 19);
            this.dtData.Mask = "00/00/0000";
            this.dtData.Name = "dtData";
            this.dtData.ReadOnly = true;
            this.dtData.Size = new System.Drawing.Size(100, 20);
            this.dtData.TabIndex = 33;
            this.dtData.ValidatingType = typeof(System.DateTime);
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(209, 43);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(75, 23);
            this.btnExchange.TabIndex = 32;
            this.btnExchange.Text = "Buscar";
            this.btnExchange.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cód. Item";
            // 
            // txtCodeItens
            // 
            this.txtCodeItens.Location = new System.Drawing.Point(103, 45);
            this.txtCodeItens.Name = "txtCodeItens";
            this.txtCodeItens.ReadOnly = true;
            this.txtCodeItens.Size = new System.Drawing.Size(100, 20);
            this.txtCodeItens.TabIndex = 30;
            this.txtCodeItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(817, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrinter
            // 
            this.btnPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrinter.Location = new System.Drawing.Point(898, 198);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnPrinter.TabIndex = 27;
            this.btnPrinter.Text = "Imprimir";
            this.btnPrinter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(979, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quantidade";
            // 
            // txtQuantiti
            // 
            this.txtQuantiti.Location = new System.Drawing.Point(103, 201);
            this.txtQuantiti.Name = "txtQuantiti";
            this.txtQuantiti.Size = new System.Drawing.Size(100, 20);
            this.txtQuantiti.TabIndex = 21;
            this.txtQuantiti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(209, 147);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 20;
            this.btnProduct.Text = "Buscar";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Produto";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(103, 175);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(281, 20);
            this.txtNameProduct.TabIndex = 18;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(103, 149);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.ReadOnly = true;
            this.txtCodeProduct.Size = new System.Drawing.Size(100, 20);
            this.txtCodeProduct.TabIndex = 17;
            this.txtCodeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cód Produto";
            // 
            // btnProvider
            // 
            this.btnProvider.Location = new System.Drawing.Point(390, 121);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(75, 23);
            this.btnProvider.TabIndex = 15;
            this.btnProvider.Text = "Buscar";
            this.btnProvider.UseVisualStyleBackColor = true;
            // 
            // txtNameProvider
            // 
            this.txtNameProvider.Location = new System.Drawing.Point(103, 123);
            this.txtNameProvider.Name = "txtNameProvider";
            this.txtNameProvider.ReadOnly = true;
            this.txtNameProvider.Size = new System.Drawing.Size(281, 20);
            this.txtNameProvider.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fornecedor";
            // 
            // txtCodeProvider
            // 
            this.txtCodeProvider.Location = new System.Drawing.Point(103, 97);
            this.txtCodeProvider.Name = "txtCodeProvider";
            this.txtCodeProvider.ReadOnly = true;
            this.txtCodeProvider.Size = new System.Drawing.Size(100, 20);
            this.txtCodeProvider.TabIndex = 12;
            this.txtCodeProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cód Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data";
            // 
            // txtCodeExchange
            // 
            this.txtCodeExchange.Location = new System.Drawing.Point(103, 71);
            this.txtCodeExchange.Name = "txtCodeExchange";
            this.txtCodeExchange.ReadOnly = true;
            this.txtCodeExchange.Size = new System.Drawing.Size(100, 20);
            this.txtCodeExchange.TabIndex = 9;
            this.txtCodeExchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(6, 228);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.Size = new System.Drawing.Size(1057, 239);
            this.dgvRegister.TabIndex = 5;
            // 
            // tblProduto
            // 
            this.tblProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblProduto.Location = new System.Drawing.Point(4, 22);
            this.tblProduto.Name = "tblProduto";
            this.tblProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tblProduto.Size = new System.Drawing.Size(1069, 473);
            this.tblProduto.TabIndex = 1;
            this.tblProduto.Text = "Cadastrar Produtos";
            // 
            // tblFornecedor
            // 
            this.tblFornecedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tblFornecedor.Name = "tblFornecedor";
            this.tblFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tblFornecedor.Size = new System.Drawing.Size(1069, 473);
            this.tblFornecedor.TabIndex = 2;
            this.tblFornecedor.Text = "Cadastrar Fornecedor";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 523);
            this.Controls.Add(this.tbcTroca);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envia Trocas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbcTroca.ResumeLayout(false);
            this.tblRegistrarTroca.ResumeLayout(false);
            this.tblRegistrarTroca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTroca;
        private System.Windows.Forms.TabPage tblRegistrarTroca;
        private System.Windows.Forms.TabPage tblProduto;
        private System.Windows.Forms.TabPage tblFornecedor;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtQuantiti;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtCodeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProvider;
        private System.Windows.Forms.TextBox txtNameProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodeExchange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox dtData;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodeItens;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

