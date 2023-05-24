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
    public partial class Razdel : Form
    {
        private readonly AppDbContext _context;
        public Razdel(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            var razdel = from s in _context.Razdels select s;
            dataGridView1.DataSource = razdel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRazdel addRazdel = new addRazdel(new AppDbContext());
            Hide();
            addRazdel.ShowDialog();
            Show();
            var razdel = from s in _context.Razdels select s;
            dataGridView1.DataSource=null;
            dataGridView1.DataSource = razdel.ToList();
        }

        private void Razdel_Load(object sender, EventArgs e)
        {

        }
    }
}
