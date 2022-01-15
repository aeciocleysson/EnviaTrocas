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
            GetAll();
            GetAllProvider();
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
                                    .ToList();

            dgvProvider.DataSource = providers;
            dgvProvider.Columns[0].HeaderText = "Código";
            dgvProvider.Columns[1].HeaderText = "Nome";
            dgvProvider.Columns[1].Width = 400;
        }

        /// <summary>
        /// Método de cadastro e update de Fornecedor
        /// </summary>
        /// <param name="viewModel"></param>
        private void InsertOrUpdate(ProviderViewModel viewModel)
        {
            if (!string.IsNullOrEmpty(txtNameRegProvider.Text))
            {
                if (string.IsNullOrEmpty(txtCodeRegProvider.Text))
                {
                    viewModel.Name = txtNameRegProvider.Text;

                    var model = new Provider(name: viewModel.Name);

                    _context.Add(model);
                    _context.SaveChanges();

                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFieldsProvider();
                    GetAllProvider();
                }
                else
                {
                    viewModel.Id = Convert.ToInt32(txtCode.Text);

                    var model = _context.Provider.Find(viewModel.Id);

                    viewModel.Name = txtNameRegProvider.Text;

                    model.Update(name: viewModel.Name);

                    _context.Update(model);
                    _context.SaveChanges();

                    MessageBox.Show("Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFieldsProvider();
                GetAllProvider();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void GetAll()
        {
            var result = _context.RegisterItens
                                .Where(w => w.IsDelete == 0)
                                .Select(s => new
                                {
                                    Codigo = s.Id,
                                    ProdutoId = s.Product.Id,
                                    Descricao = s.Product.Description,
                                    Quantidade = s.Quantidade
                                }).ToList();


            dgvRegister.DataSource = result;

            dgvRegister.Columns[0].HeaderText = "Código";
            dgvRegister.Columns[1].HeaderText = "Cod. Produto";
            dgvRegister.Columns[2].HeaderText = "Descrição";
            dgvRegister.Columns[3].HeaderText = "Quantidade";
            dgvRegister.Columns[2].Width = 300;
        }



        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            txtCodeExchange.Clear();
            txtCodeItens.Clear();
            dtData.Clear();
            txtCodeProvider.Clear();
            txtNameProvider.Clear();
            txtCodeProduct.Clear();
            txtNameProduct.Clear();
            txtQuantiti.Clear();
            txtQuantiti.Select();
            txtQuantiti.Focus();
            dgvRegister.DataSource = null;
        }

        private void btnCancelarProvider_Click(object sender, EventArgs e)
        {
            ClearFieldsProvider();
        }

        private void btnSaveProvider_Click(object sender, EventArgs e)
        {
            var viewModel = new ProviderViewModel();
            InsertOrUpdate(viewModel);
        }

        private void btnExcluirProvider_Click(object sender, EventArgs e)
        {
            var viewModel = new ProviderViewModel();
            DeleteProvider(viewModel);
        }
    }
}
