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
    public partial class tables : Form
    {
        private readonly AppDbContext _context;
        public tables(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            var tables= from s in _context.Tables select s;
            dataGridView1.DataSource = tables.ToList();
        }

        private void tables_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = new Table
            {
                Status = "Свободный",
                UserId = 2
            };
            _context.Add(table);
            _context.SaveChanges();
            dataGridView1.DataSource = null;
            var tables = from s in _context.Tables select s;
            dataGridView1.DataSource=tables.ToList();
        }
    }
}
