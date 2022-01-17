using EnviaTrocas.Data;
using System.Linq;
using System.Windows.Forms;

namespace EnviaTrocas
{
    public partial class FrmListRegister : Form
    {
        private DataContext _context;
        public FrmListRegister()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAll();
        }

        private void GetAll()
        {
            var result = _context.Register
                                 .Where(w => w.IsDelete == 0)
                                 .Select(s => new
                                 {
                                     Codigo = s.Id,
                                     Data = s.Inserted,
                                     CodFornecedor = s.ProviderId,
                                     Fornecedor = s.Provider.Name
                                 }).OrderByDescending(o => o.Data).ToList();

            dgvListRegister.DataSource = result;

            dgvListRegister.Columns[0].HeaderText = "Código";
            dgvListRegister.Columns[1].HeaderText = "Data";
            dgvListRegister.Columns[2].HeaderText = "Cód. Fornec";
            dgvListRegister.Columns[3].HeaderText = "Fornecedor";
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void dgvListRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListRegister.Rows.Count == 0)
                return;
            else
                DialogResult = DialogResult.OK;

            Close();
        }
    }
}
