using EnviaTrocas.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnviaTrocas
{
    public partial class FrmListProduct : Form
    {
        private DataContext _context;
        public FrmListProduct()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAll();
        }

        private void GetAll()
        {
            var products = _context.Product
                                   .Where(w => w.IsDelete == 0)
                                   .Select(s => new
                                   {
                                       Codigo = s.Id,
                                       Marca = s.Brand,
                                       Descricao = s.Description
                                   }).OrderBy(o => o.Marca)
                                   .ToList();

            dgvListProducts.DataSource = products;
            dgvListProducts.Columns[0].HeaderText = "Código";
            dgvListProducts.Columns[1].HeaderText = "Marca";
            dgvListProducts.Columns[2].HeaderText = "Descrição";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListProducts.Rows.Count == 0)
                return;
            else
                DialogResult = DialogResult.OK;

            Close();
        }
    }
}
