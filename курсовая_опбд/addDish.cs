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
    public partial class addDish : Form
    {
        private readonly AppDbContext _context;
        public addDish(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void addDish_Load(object sender, EventArgs e)
        {
            var razdel = from s in _context.Razdels select s.Title;
            comboBox1.DataSource = razdel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Dish = new Menus
            {
                IdRazdel = comboBox1.SelectedIndex + 1,
                Price = Convert.ToInt32(textBox4.Text),
                Weight = Convert.ToInt32(textBox3.Text),
                Title = textBox1.Text
            };
            _context.Add(Dish);
            _context.SaveChanges();
            Close();
        }
    }
}
