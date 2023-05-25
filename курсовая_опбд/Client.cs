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
    public partial class Client : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public Client(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            var menu = from s in _context.Users select s;
            dataGridView1.DataSource = menu.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserv res = new Reserv(new AppDbContext(),_user);
            res.ShowDialog();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            var razdel = from s in _context.Razdels select s.Title;
            comboBox1.DataSource = razdel.ToList();
            comboBox1.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                var menu = from s in _context.Users select s;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = menu.ToList();
            }
            else
            {
                var menu = from s in _context.Menus where s.IdRazdel == comboBox1.SelectedIndex + 1 select s;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = menu.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
        }
    }
}
