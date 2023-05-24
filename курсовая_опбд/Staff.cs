using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_опбд
{
    public partial class Staff : Form
    {
        private readonly AppDbContext _context;
        public Staff(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            var staff = from s in _context.Sotrudniks select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = staff.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStaff add = new addStaff(new AppDbContext());
            Hide();
            add.ShowDialog();
            Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
