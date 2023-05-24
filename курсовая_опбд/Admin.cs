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
    public partial class Admin : Form
    {
        private readonly AppDbContext _context;
       
        public Admin(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(new AppDbContext());
            staff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(new AppDbContext()); 
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sostav sostav = new Sostav(new AppDbContext());
            sostav.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Razdel razdel = new Razdel(new AppDbContext());
            razdel.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
