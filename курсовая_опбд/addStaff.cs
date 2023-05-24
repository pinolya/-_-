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
    public partial class addStaff : Form
    {
        private readonly AppDbContext _context;
        public addStaff(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
