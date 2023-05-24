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
    public partial class Menu : Form
    {
        private readonly AppDbContext _context;
        public Menu(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            var menu = from s in _context.Menus select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = menu.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDish dish = new addDish(new AppDbContext());
            Hide();
            dish.ShowDialog();
            Close();
            var menu = from s in _context.Menus select s;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = menu.ToList();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
