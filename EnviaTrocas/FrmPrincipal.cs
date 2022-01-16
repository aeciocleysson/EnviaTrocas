using EnviaTrocas.Data;
using EnviaTrocas.Model;
using EnviaTrocas.ViewModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnviaTrocas
{
    public partial class FrmPrincipal : Form
    {
        private DataContext _context;
        public FrmPrincipal()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAllProvider();
            GetAllProducts();
        }

        #region Fornecedor

        /// <summary>
        /// Limpar os campos
        /// </summary>
        private void ClearFieldsProvider()
        {
            txtCodeRegProvider.Clear();
            txtNameRegProvider.Clear();
            txtNameRegProvider.Select();
            txtNameRegProvider.Focus();
        }

        /// <summary>
        ///  Listar Fornecedores
        /// </summary>
        private void GetAllProvider()
        {
            var providers = _context.Provider
                                    .Where(w => w.IsDelete == 0)
                                    .Select(s => new
                                    {
                                        s.Id,
                                        s.Name
                                    })
                                    .OrderBy(o => o.Name)
                                    .ToList();

            dgvProvider.DataSource = providers;
            dgvProvider.Columns[0].HeaderText = "Código";
            dgvProvider.Columns[1].HeaderText = "Nome";
        }

        /// <summary>
        /// Método de cadastro e update de Fornecedor
        /// </summary>
        /// <param name="viewModel"></param>
        private void InsertOrUpdateProvider(ProviderViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtNameRegProvider.Text))
            {
                if (string.IsNullOrEmpty(txtCodeRegProvider.Text))
                {
                    viewModel.Name = txtNameRegProvider.Text;

                    var model = new Provider(name: viewModel.Name);

                    _context.Add(model);
                    _context.SaveChanges();

                    ClearFieldsProvider();
                    GetAllProvider();
                }
                else
                {
                    viewModel.Id = Convert.ToInt32(txtCodeRegProvider.Text);

                    var model = _context.Provider.Find(viewModel.Id);

                    viewModel.Name = txtNameRegProvider.Text;

                    model.Update(name: viewModel.Name);

                    _context.Update(model);
                    _context.SaveChanges();

                    ClearFieldsProvider();
                    GetAllProvider();
                }
            }
            else
            {
                MessageBox.Show("Nome é obrigatório!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que seta o campo IsDelete com valor 1 informando que foi excluido
        /// </summary>
        /// <param name="viewModel"></param>
        public void DeleteProvider(ProviderViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtCodeRegProvider.Text))
            {
                viewModel.Id = Convert.ToInt32(txtCodeRegProvider.Text);
                viewModel.IsDelete = 1;
                var model = _context.Provider.Find(viewModel.Id);

                model.Delete(isDelete: viewModel.IsDelete);

                _context.Update(model);
                _context.SaveChanges();

                ClearFieldsProvider();
                GetAllProvider();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Produto

        /// <summary>
        /// Limpar os campos
        /// </summary>
        private void ClearFieldsProduct()
        {
            txtCodeRegProduct.Clear();
            txtpesquisarProduct.Clear();
            txtRegBrand.Clear();
            txtRegDescProduct.Clear();
            txtRegDescProduct.Focus();
            txtRegDescProduct.Select();
        }

        /// <summary>
        /// Carregar todos os produtos cadastrados
        /// </summary>
        private void GetAllProducts()
        {
            var products = _context.Product
                                   .Where(w => w.IsDelete == 0)
                                   .Select(s => new
                                   {
                                       s.Id,
                                       s.Brand,
                                       s.Description,
                                       s.Inserted
                                   })
                                   .OrderBy(o => o.Brand)
                                   .ToList();

            dgvProducts.DataSource = products;

            dgvProducts.Columns[0].HeaderText = "Código";
            dgvProducts.Columns[1].HeaderText = "Marca";
            dgvProducts.Columns[2].HeaderText = "Descrição";
            dgvProducts.Columns[3].HeaderText = "Data Cadastro";
        }

        /// <summary>
        /// Pesquisa um produto por descrição
        /// </summary>
        /// <param name="texto"></param>
        private void GetAllProducts(string texto)
        {
            var products = _context.Product
                                   .Where(w => w.IsDelete == 0 && w.Description.Contains(texto) ||
                                               w.IsDelete == 0 && w.Brand.Contains(texto))
                                   .Select(s => new
                                   {
                                       s.Id,
                                       s.Brand,
                                       s.Description,
                                       s.Inserted
                                   })
                                   .OrderBy(o => o.Brand)
                                   .ToList();

            dgvProducts.DataSource = products;

            dgvProducts.Columns[0].HeaderText = "Código";
            dgvProducts.Columns[1].HeaderText = "Marca";
            dgvProducts.Columns[2].HeaderText = "Descrição";
            dgvProducts.Columns[3].HeaderText = "Data Cadastro";
        }

        /// <summary>
        /// Inserir e aualizar um Produto
        /// </summary>
        /// <param name="viewModel"></param>
        public void InsertOrUpdateProduct(ProductViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtRegBrand.Text) && !string.IsNullOrEmpty(txtRegDescProduct.Text))
            {
                if (string.IsNullOrEmpty(txtCodeRegProduct.Text))
                {
                    viewModel.Brand = txtRegBrand.Text;
                    viewModel.Description = txtRegDescProduct.Text;

                    var model = new Product(brand: viewModel.Brand,
                        description: viewModel.Description);

                    _context.Add(model);
                    _context.SaveChanges();

                    ClearFieldsProduct();
                    GetAllProducts();
                }
                else
                {
                    viewModel.Id = Convert.ToInt32(txtCodeRegProduct.Text);

                    var model = _context.Product.Find(viewModel.Id);

                    viewModel.Brand = txtRegBrand.Text;
                    viewModel.Description = txtRegDescProduct.Text;

                    model.Update(brand: viewModel.Brand,
                        description: viewModel.Description);

                    _context.Update(model);
                    _context.SaveChanges();

                    ClearFieldsProduct();
                    GetAllProducts();
                }
            }
            else
            {
                MessageBox.Show("Marca e Descrição deve ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que seta o campo IsDelete com valor 1 informando que foi excluido
        /// </summary>
        /// <param name="viewModel"></param>
        public void DeleteProduct(ProductViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtCodeRegProduct.Text))
            {
                viewModel.Id = Convert.ToInt32(txtCodeRegProduct.Text);

                var model = _context.Product.Find(viewModel.Id);

                viewModel.IsDelete = 1;

                model.Delete(isDelete: viewModel.IsDelete);

                _context.Update(model);
                _context.SaveChanges();

                ClearFieldsProduct();
                GetAllProducts();
            }
            else
            {
                MessageBox.Show("Selecione um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cadastrar as trocas

        private void ClearFieldsRegister()
        {
            txtCodeExchange.Clear();
            txtCodeItens.Clear();
            dtDataRegister.Clear();
            txtCodeProvider.Clear();
            txtNameProvider.Clear();
            txtCodeProduct.Clear();
            txtNameProduct.Clear();
            txtQuantiti.Clear();
            txtQuantiti.Select();
            txtQuantiti.Focus();
        }

        public void SelectProvider()
        {
            var provider = new FrmListProvider();
            provider.ShowDialog();

            if (provider.DialogResult == DialogResult.OK)
            {
                var dataGrid = provider.dgvListProvider.Rows[provider.dgvListProvider.CurrentRow.Index];

                txtCodeProvider.Text = dataGrid.Cells[0].Value.ToString();
                txtNameProvider.Text = dataGrid.Cells[1].Value.ToString();
            }
        }

        public void SelectProducts()
        {
            var provider = new FrmListProduct();
            provider.ShowDialog();

            if (provider.DialogResult == DialogResult.OK)
            {
                var dataGrid = provider.dgvListProducts.Rows[provider.dgvListProducts.CurrentRow.Index];

                txtCodeProduct.Text = dataGrid.Cells[0].Value.ToString();
                txtNameProduct.Text = dataGrid.Cells[2].Value.ToString();

                txtQuantiti.Focus();
                txtQuantiti.Select();
            }
        }

        #endregion

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearFieldsRegister();
            dgvRegister.DataSource = null;
        }

        private void btnCancelarProvider_Click(object sender, EventArgs e)
        {
            ClearFieldsProvider();
        }

        private void btnSaveProvider_Click(object sender, EventArgs e)
        {
            var viewModel = new ProviderViewModel();
            InsertOrUpdateProvider(viewModel);
        }

        private void btnExcluirProvider_Click(object sender, EventArgs e)
        {
            var viewModel = new ProviderViewModel();
            DeleteProvider(viewModel);
        }

        private void dgvProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProvider.Rows[e.RowIndex];

                txtCodeRegProvider.Text = row.Cells[0].Value.ToString();
                txtNameRegProvider.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvProvider_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvProvider.CurrentRow.Index >= 0)
            {
                var row = dgvProvider.Rows[dgvProvider.CurrentRow.Index];

                txtCodeRegProvider.Text = row.Cells[0].Value.ToString();
                txtNameRegProvider.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            ClearFieldsProduct();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            var viewModel = new ProductViewModel();
            InsertOrUpdateProduct(viewModel);
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProducts.Rows[e.RowIndex];

                txtCodeRegProduct.Text = row.Cells[0].Value.ToString();
                txtRegBrand.Text = row.Cells[1].Value.ToString();
                txtRegDescProduct.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvProducts_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvProducts.CurrentRow.Index >= 0)
            {
                var row = dgvProducts.Rows[dgvProducts.CurrentRow.Index];

                txtCodeRegProduct.Text = row.Cells[0].Value.ToString();
                txtRegBrand.Text = row.Cells[1].Value.ToString();
                txtRegDescProduct.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtpesquisarProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpesquisarProduct.Text.Trim()))
            {
                GetAllProducts();
            }
            else
            {
                GetAllProducts(txtpesquisarProduct.Text);
            }
        }

        private void btnExcluirProduct_Click(object sender, EventArgs e)
        {
            var viewModel = new ProductViewModel();
            DeleteProduct(viewModel);
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            SelectProvider();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SelectProducts();
        }
    }
}
