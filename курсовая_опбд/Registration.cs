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
    public partial class Registration : Form
    {
        private readonly AppDbContext _context;
        public Registration(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button_zareg_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = textBox_name.Text,
                Surname = textBox_surname.Text,
                Phone = textBox_phone.Text,
                Login =textBox_login.Text,
                Password = textBox_pass.Text
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!",
           "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
