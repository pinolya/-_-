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
    public partial class Reserv : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public Reserv(AppDbContext context,User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            dataGridView1.DataSource = null;
            var stoliki = from s in _context.Tables where s.UserId == null select s;
            dataGridView1.DataSource = stoliki.ToList();
        }

        private void Reserv_Load(object sender, EventArgs e)
        {

        }
    }
}
