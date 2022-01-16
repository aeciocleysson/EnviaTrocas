using EnviaTrocas.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EnviaTrocas
{
    public partial class FrmListProvider : Form
    {
        private DataContext _context;
        public FrmListProvider()
        {
            InitializeComponent();
            _context = new DataContext();
            GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetAll()
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

            dgvListProvider.DataSource = providers;
            dgvListProvider.Columns[0].HeaderText = "Código";
            dgvListProvider.Columns[1].HeaderText = "Nome";            
        }

        private void dgvListProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListProvider.Rows.Count == 0)
                return;
            else
                DialogResult = DialogResult.OK;

            Close();
        }
    }
}
