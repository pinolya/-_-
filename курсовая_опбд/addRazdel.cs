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
    public partial class addRazdel : Form
    {
        private readonly AppDbContext _context;
        public addRazdel(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach(var a in _context.Razdels)
            {
                if (a.Title == textBox2.Text)
                {
                    MessageBox.Show("Такой раздел уже есть!");
                    flag = false;
                }
            }
            if (flag)
            {
                var razdel = new Razdels
                {
                    Title = textBox2.Text
                };
                _context.Add(razdel);
                _context.SaveChanges();
                Close();
            }

        }
    }
}
