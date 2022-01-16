
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tbcTroca = new System.Windows.Forms.TabControl();
            this.tblRegistrarTroca = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDataRegister = new System.Windows.Forms.MaskedTextBox();
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
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnExcluirProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpesquisarProduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegDescProduct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegBrand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodeRegProduct = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tblFornecedor = new System.Windows.Forms.TabPage();
            this.btnSaveProvider = new System.Windows.Forms.Button();
            this.btnExcluirProvider = new System.Windows.Forms.Button();
            this.btnCancelarProvider = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameRegProvider = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodeRegProvider = new System.Windows.Forms.TextBox();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbcTroca.SuspendLayout();
            this.tblRegistrarTroca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.tblProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tblFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tblRegistrarTroca.Controls.Add(this.dtDataRegister);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cód. Troca";
            // 
            // dtDataRegister
            // 
            this.dtDataRegister.Location = new System.Drawing.Point(103, 19);
            this.dtDataRegister.Mask = "00/00/0000";
            this.dtDataRegister.Name = "dtDataRegister";
            this.dtDataRegister.ReadOnly = true;
            this.dtDataRegister.Size = new System.Drawing.Size(100, 20);
            this.dtDataRegister.TabIndex = 33;
            this.dtDataRegister.ValidatingType = typeof(System.DateTime);
            // 
            // btnExchange
            // 
            this.btnExchange.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnPrinter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(979, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnProduct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(390, 174);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 20;
            this.btnProduct.Text = "Buscar";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
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
            this.btnProvider.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvider.Location = new System.Drawing.Point(390, 121);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(75, 23);
            this.btnProvider.TabIndex = 15;
            this.btnProvider.Text = "Buscar";
            this.btnProvider.UseVisualStyleBackColor = true;
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
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
            this.dgvRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.tblProduto.Controls.Add(this.pictureBox1);
            this.tblProduto.Controls.Add(this.btnSaveProduct);
            this.tblProduto.Controls.Add(this.btnExcluirProduct);
            this.tblProduto.Controls.Add(this.btnCancelProduct);
            this.tblProduto.Controls.Add(this.label12);
            this.tblProduto.Controls.Add(this.txtpesquisarProduct);
            this.tblProduto.Controls.Add(this.label11);
            this.tblProduto.Controls.Add(this.txtRegDescProduct);
            this.tblProduto.Controls.Add(this.label10);
            this.tblProduto.Controls.Add(this.txtRegBrand);
            this.tblProduto.Controls.Add(this.label9);
            this.tblProduto.Controls.Add(this.txtCodeRegProduct);
            this.tblProduto.Controls.Add(this.dgvProducts);
            this.tblProduto.Location = new System.Drawing.Point(4, 22);
            this.tblProduto.Name = "tblProduto";
            this.tblProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tblProduto.Size = new System.Drawing.Size(1069, 473);
            this.tblProduto.TabIndex = 1;
            this.tblProduto.Text = "Cadastrar Produtos";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProduct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(817, 198);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 10;
            this.btnSaveProduct.Text = "Salvar";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnExcluirProduct
            // 
            this.btnExcluirProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProduct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduct.Location = new System.Drawing.Point(898, 198);
            this.btnExcluirProduct.Name = "btnExcluirProduct";
            this.btnExcluirProduct.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduct.TabIndex = 11;
            this.btnExcluirProduct.Text = "Excluir";
            this.btnExcluirProduct.UseVisualStyleBackColor = true;
            this.btnExcluirProduct.Click += new System.EventHandler(this.btnExcluirProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelProduct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(979, 198);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProduct.TabIndex = 12;
            this.btnCancelProduct.Text = "Cancelar";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 9;
            this.label12.Text = "Pesquisar";
            // 
            // txtpesquisarProduct
            // 
            this.txtpesquisarProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpesquisarProduct.Location = new System.Drawing.Point(103, 192);
            this.txtpesquisarProduct.Name = "txtpesquisarProduct";
            this.txtpesquisarProduct.Size = new System.Drawing.Size(470, 20);
            this.txtpesquisarProduct.TabIndex = 8;
            this.txtpesquisarProduct.TextChanged += new System.EventHandler(this.txtpesquisarProduct_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Descrição";
            // 
            // txtRegDescProduct
            // 
            this.txtRegDescProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegDescProduct.Location = new System.Drawing.Point(103, 71);
            this.txtRegDescProduct.Name = "txtRegDescProduct";
            this.txtRegDescProduct.Size = new System.Drawing.Size(342, 20);
            this.txtRegDescProduct.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "Marca";
            // 
            // txtRegBrand
            // 
            this.txtRegBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegBrand.Location = new System.Drawing.Point(103, 45);
            this.txtRegBrand.Name = "txtRegBrand";
            this.txtRegBrand.Size = new System.Drawing.Size(228, 20);
            this.txtRegBrand.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cód. Produto";
            // 
            // txtCodeRegProduct
            // 
            this.txtCodeRegProduct.Location = new System.Drawing.Point(103, 19);
            this.txtCodeRegProduct.Name = "txtCodeRegProduct";
            this.txtCodeRegProduct.ReadOnly = true;
            this.txtCodeRegProduct.Size = new System.Drawing.Size(100, 20);
            this.txtCodeRegProduct.TabIndex = 2;
            this.txtCodeRegProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 228);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1057, 239);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProducts_KeyUp);
            // 
            // tblFornecedor
            // 
            this.tblFornecedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tblFornecedor.Controls.Add(this.pictureBox2);
            this.tblFornecedor.Controls.Add(this.btnSaveProvider);
            this.tblFornecedor.Controls.Add(this.btnExcluirProvider);
            this.tblFornecedor.Controls.Add(this.btnCancelarProvider);
            this.tblFornecedor.Controls.Add(this.label13);
            this.tblFornecedor.Controls.Add(this.txtNameRegProvider);
            this.tblFornecedor.Controls.Add(this.label14);
            this.tblFornecedor.Controls.Add(this.txtCodeRegProvider);
            this.tblFornecedor.Controls.Add(this.dgvProvider);
            this.tblFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tblFornecedor.Name = "tblFornecedor";
            this.tblFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tblFornecedor.Size = new System.Drawing.Size(1069, 473);
            this.tblFornecedor.TabIndex = 2;
            this.tblFornecedor.Text = "Cadastrar Fornecedor";
            // 
            // btnSaveProvider
            // 
            this.btnSaveProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProvider.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProvider.Location = new System.Drawing.Point(817, 198);
            this.btnSaveProvider.Name = "btnSaveProvider";
            this.btnSaveProvider.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProvider.TabIndex = 8;
            this.btnSaveProvider.Text = "Salvar";
            this.btnSaveProvider.UseVisualStyleBackColor = true;
            this.btnSaveProvider.Click += new System.EventHandler(this.btnSaveProvider_Click);
            // 
            // btnExcluirProvider
            // 
            this.btnExcluirProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProvider.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProvider.Location = new System.Drawing.Point(898, 198);
            this.btnExcluirProvider.Name = "btnExcluirProvider";
            this.btnExcluirProvider.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProvider.TabIndex = 9;
            this.btnExcluirProvider.Text = "Excluir";
            this.btnExcluirProvider.UseVisualStyleBackColor = true;
            this.btnExcluirProvider.Click += new System.EventHandler(this.btnExcluirProvider_Click);
            // 
            // btnCancelarProvider
            // 
            this.btnCancelarProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProvider.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProvider.Location = new System.Drawing.Point(979, 198);
            this.btnCancelarProvider.Name = "btnCancelarProvider";
            this.btnCancelarProvider.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProvider.TabIndex = 10;
            this.btnCancelarProvider.Text = "Cancelar";
            this.btnCancelarProvider.UseVisualStyleBackColor = true;
            this.btnCancelarProvider.Click += new System.EventHandler(this.btnCancelarProvider_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nome";
            // 
            // txtNameRegProvider
            // 
            this.txtNameRegProvider.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameRegProvider.Location = new System.Drawing.Point(103, 45);
            this.txtNameRegProvider.Name = "txtNameRegProvider";
            this.txtNameRegProvider.Size = new System.Drawing.Size(373, 20);
            this.txtNameRegProvider.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Código";
            // 
            // txtCodeRegProvider
            // 
            this.txtCodeRegProvider.Location = new System.Drawing.Point(103, 19);
            this.txtCodeRegProvider.Name = "txtCodeRegProvider";
            this.txtCodeRegProvider.ReadOnly = true;
            this.txtCodeRegProvider.Size = new System.Drawing.Size(100, 20);
            this.txtCodeRegProvider.TabIndex = 4;
            this.txtCodeRegProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvProvider
            // 
            this.dgvProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Location = new System.Drawing.Point(6, 228);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvider.Size = new System.Drawing.Size(1057, 239);
            this.dgvProvider.TabIndex = 1;
            this.dgvProvider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvider_CellDoubleClick);
            this.dgvProvider.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProvider_KeyUp);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(922, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 109);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::EnviaTrocas.Properties.Resources.produto;
            this.pictureBox1.Location = new System.Drawing.Point(922, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::EnviaTrocas.Properties.Resources.fornecedor;
            this.pictureBox2.Location = new System.Drawing.Point(922, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.tblProduto.ResumeLayout(false);
            this.tblProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tblFornecedor.ResumeLayout(false);
            this.tblFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox dtDataRegister;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodeItens;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodeRegProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnExcluirProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpesquisarProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegDescProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNameRegProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodeRegProvider;
        private System.Windows.Forms.Button btnSaveProvider;
        private System.Windows.Forms.Button btnExcluirProvider;
        private System.Windows.Forms.Button btnCancelarProvider;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

