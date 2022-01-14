using EnviaTrocas.Data;
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
        }

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
    }
}
