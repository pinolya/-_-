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
    public partial class Sostav : Form
    {
        private readonly AppDbContext _context;
        public Sostav(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSostav sostav = new addSostav();
            sostav.ShowDialog();
        }

        private void Sostav_Load(object sender, EventArgs e)
        {

        }
    }
}
